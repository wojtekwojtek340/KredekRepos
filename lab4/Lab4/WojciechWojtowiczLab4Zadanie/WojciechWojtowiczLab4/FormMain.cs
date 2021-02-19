using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WojciechWojtowiczLab4.Models;
using WojciechWojtowiczLab4.Repositories;

namespace WojciechWojtowiczLab4
{
    public partial class FormMain : Form
    {
        private readonly ISkiJumpingGeneric<Jumper> _jumpers;
        private readonly ISkiJumpingGeneric<Country> _countries;
        private readonly ISkiJumpingGeneric<Trainer> _trainers;
        private readonly ISkiJumpingGeneric<Sponsor> _sponsors;
        private readonly ISkiJumpingGeneric<Salary> _salaries;

        public FormMain()
        {
            InitializeComponent();
            _jumpers = new SkiJumpingGeneric<Jumper>();
            _countries = new SkiJumpingGeneric<Country>();
            _trainers = new SkiJumpingGeneric<Trainer>();
            _sponsors = new SkiJumpingGeneric<Sponsor>();
            _salaries = new SkiJumpingGeneric<Salary>();
            Load();
        }

        /// <summary>
        /// ładowanie danych
        /// </summary>
        private new void Load()
        {
            dataGridViewCountries.DataSource = _countries.GetAll();
            dataGridViewJumpers.DataSource = _jumpers.GetAll();
            dataGridViewTrainers.DataSource = _trainers.GetAll();
            dataGridViewSponsors.DataSource = _sponsors.GetAll();
        }

        /// <summary>
        /// dodanie skoczka do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperAdd_Click(object sender, EventArgs e)
        {
            var jumperFirstName = textBoxJumperFirstName.Text;
            var jumperLastName = textBoxJumperLastName.Text;
            var jumperBirthdate = dateTimePickerJumper.Text;
            var countryId = textBoxJumperCountryId.Text;

            Jumper newJumper = new Jumper
            {
                FirstName = jumperFirstName,
                LastName = jumperLastName,
                Birtdate = Convert.ToDateTime(jumperBirthdate),
                CountryId = Int32.Parse(countryId),
            };

            _jumpers.Create(newJumper);
            _jumpers.Save();
            Load();
        }

        /// <summary>
        /// dodanie kraju do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryAdd_Click(object sender, EventArgs e)
        {
            var countryName = textBoxCountryName.Text;
            var countryRecord = textBoxCountryRecord.Text;

            Country newCountry = new Country
            {
                Name = countryName,
                CountryRecord = float.Parse(countryRecord)
            };

            _countries.Create(newCountry);
            _countries.Save();
            Load();
        }

        /// <summary>
        /// usunięcie skoczka z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperDelete_Click(object sender, EventArgs e)
        {
            var selectedJumperIndex = Int32.Parse(dataGridViewJumpers.SelectedRows[0].Cells[0].Value.ToString());

            _jumpers.DeleteById(selectedJumperIndex);
            _jumpers.Save();

            Load();
        }

        /// <summary>
        /// edycja danych skoczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperUpdate_Click(object sender, EventArgs e)
        {
            var selectedJumperIndex = Int32.Parse(dataGridViewJumpers.SelectedRows[0].Cells[0].Value.ToString());
            var showJumper = _jumpers.GetById(selectedJumperIndex);

            textBoxUpdateJumperId.Text = showJumper.Id.ToString();
            textBoxUpdateJumperFirstName.Text = showJumper.FirstName.ToString();
            textBoxUpdateJumperLastName.Text = showJumper.LastName.ToString();
            dateTimePickerUpdateJumper.Text = showJumper.Birtdate.ToString();
            textBoxUpdateCountryId.Text = showJumper.CountryId.ToString();
        }

        /// <summary>
        /// wyświetlanie informacji o skoczku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperShow_Click(object sender, EventArgs e)
        {
            var selectedJumperIndex = Int32.Parse(dataGridViewJumpers.SelectedRows[0].Cells[0].Value.ToString());
            var showJumper = _jumpers.GetById(selectedJumperIndex);


            showJumper.Country = _countries.GetById(showJumper.CountryId);
            MessageBox.Show("Kraj skoczka " + showJumper.Country.Name);
            showJumper.Country = null;
        }

        /// <summary>
        /// usinięcie kraju z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryDelete_Click(object sender, EventArgs e)
        {
            var selectedCountryIndex = Int32.Parse(dataGridViewCountries.SelectedRows[0].Cells[0].Value.ToString());

            _countries.DeleteById(selectedCountryIndex);
            _countries.Save();
            Load();

        }

        /// <summary>
        /// edycja danych kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryUpdate_Click(object sender, EventArgs e)
        {
            var selectedCountryIndex = Int32.Parse(dataGridViewCountries.SelectedRows[0].Cells[0].Value.ToString());
            var showCountry = _countries.GetById(selectedCountryIndex);

            textBoxUpdateCountryyId.Text = showCountry.Id.ToString();
            textBoxUpdateCountryName.Text = showCountry.Name.ToString();
            textBoxUpdateCountryRecord.Text = showCountry.CountryRecord.ToString();
        }

        /// <summary>
        /// wyświetlanie informacji o kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryShow_Click(object sender, EventArgs e)
        {
            int jumpersCount = 0;

            var selectedCountryIndex = Int32.Parse(dataGridViewCountries.SelectedRows[0].Cells[0].Value.ToString());
            var showCountry = _countries.GetById(selectedCountryIndex);

            for (int j = 0; j < _jumpers.GetAll().Count; j++)
            {
                if (_jumpers.GetAll()[j].CountryId == showCountry.Id)
                {
                    jumpersCount++;
                }
            }

            MessageBox.Show("Kraj " + showCountry.Name + " posiada " + jumpersCount + " skoczków");
        }

        /// <summary>
        /// zapis zmian danych skoczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperSaveChanges_Click(object sender, EventArgs e)
        {
            int jumperUpdatedId = Int32.Parse(textBoxUpdateJumperId.Text);
            var jumperUpdatedFirstName = textBoxUpdateJumperFirstName.Text;
            var jumperUpdatedLastName = textBoxUpdateJumperLastName.Text;
            var jumperUpdatedBirthdate = dateTimePickerUpdateJumper.Value;
            int jumperUpdatedCountryId = Int32.Parse(textBoxUpdateCountryId.Text);

            Jumper editJumper = _jumpers.GetById(jumperUpdatedId);

            editJumper.Id = jumperUpdatedId;
            editJumper.FirstName = jumperUpdatedFirstName;
            editJumper.LastName = jumperUpdatedLastName;
            editJumper.Birtdate = jumperUpdatedBirthdate;
            editJumper.CountryId = jumperUpdatedCountryId;

            _jumpers.Update(editJumper);
            _jumpers.Save();
            Load();
        }

        /// <summary>
        /// dodanie trenera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrainerAdd_Click(object sender, EventArgs e)
        {
            var trainerFirstName = textBoxTrainerFirstName.Text;
            var trainerLastName = textBoxTrainerLastName.Text;
            var trainerBirthdate = dateTimePickerTrainer.Text;
            var countryId = textBoxTrainerCountryId.Text;

            Trainer newTrainer = new Trainer
            {
                FirstName = trainerFirstName,
                LastName = trainerLastName,
                Birtdate = Convert.ToDateTime(trainerBirthdate),
                CountryId = Int32.Parse(countryId),
            };

            _trainers.Create(newTrainer);
            _trainers.Save();
            Load();
        }

        /// <summary>
        /// przycisk pokazuje ile skoczow trenuje dany trener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumpersShow_Click(object sender, EventArgs e)
        {
            var selectedTrainerIndex = Int32.Parse(dataGridViewTrainers.SelectedRows[0].Cells[0].Value.ToString());
            var showTrainer = _trainers.GetById(selectedTrainerIndex);
            int jumpersCount = 0;

            for (int j = 0; j < _jumpers.GetAll().Count; j++)
            {
                if (_jumpers.GetAll()[j].CountryId == showTrainer.CountryId)
                {
                    jumpersCount++;
                }
            }
            MessageBox.Show("Trener " + showTrainer.FirstName + " " + showTrainer.LastName + " trenuje " + jumpersCount + " skoczków");
        }

        /// <summary>
        /// zapis zmian danych trenera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrainerSaveChanges_Click(object sender, EventArgs e)
        {
            int trainerUpdatedId = Int32.Parse(textBoxUpdateTrainerId.Text);
            var trainerUpdatedFirstName = textBoxUpdateTrainerFirstName.Text;
            var trainerUpdatedLastName = textBoxUpdateTrainerLastName.Text;
            var trainerUpdatedBirthdate = dateTimePickerUpdateTrainer.Value;
            int trainerUpdatedCountryId = Int32.Parse(textBoxUpdateCountryIdTrainer.Text);

            Trainer editTrainer = _trainers.GetById(trainerUpdatedId);

            editTrainer.Id = trainerUpdatedId;
            editTrainer.FirstName = trainerUpdatedFirstName;
            editTrainer.LastName = trainerUpdatedLastName;
            editTrainer.Birtdate = trainerUpdatedBirthdate;
            editTrainer.CountryId = trainerUpdatedCountryId;

            _trainers.Update(editTrainer);
            _trainers.Save();
            Load();
        }

        /// <summary>
        /// wyswietlenie danych trenera w textboxach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrainerEdit_Click(object sender, EventArgs e)
        {
            var selectedTrainerIndex = Int32.Parse(dataGridViewTrainers.SelectedRows[0].Cells[0].Value.ToString());
            var showTrainer = _trainers.GetById(selectedTrainerIndex);

            textBoxUpdateTrainerId.Text = showTrainer.Id.ToString();
            textBoxUpdateTrainerFirstName.Text = showTrainer.FirstName.ToString();
            textBoxUpdateTrainerLastName.Text = showTrainer.LastName.ToString();
            dateTimePickerUpdateTrainer.Value = showTrainer.Birtdate;
            textBoxUpdateCountryIdTrainer.Text = showTrainer.CountryId.ToString();
        }

        /// <summary>
        /// usunięcie trenera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrainerDelete_Click(object sender, EventArgs e)
        {
            var selectedTrainerIndex = Int32.Parse(dataGridViewTrainers.SelectedRows[0].Cells[0].Value.ToString());

            _trainers.DeleteById(selectedTrainerIndex);
            _trainers.Save();

            Load();
        }

        /// <summary>
        /// przycisk aktualizuje dane kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountrySaveChanges_Click(object sender, EventArgs e)
        {
            var countryName = textBoxCountryName.Text;
            var countryRecord = textBoxCountryRecord.Text;
            var countryId = Int32.Parse(textBoxUpdateCountryyId.Text);

            Country newCountry = _countries.GetById(countryId);

            newCountry.Id = countryId;
            newCountry.Name = countryName;
            newCountry.CountryRecord = float.Parse(countryRecord);

            _countries.Update(newCountry);
            _countries.Save();
            Load();
        }

        /// <summary>
        /// przycisk pokazuje którego skoczka sponsoruje dany sponsor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSponsorShowJumper_Click(object sender, EventArgs e)
        {
            var selectedSponsorIndex = Int32.Parse(dataGridViewSponsors.SelectedRows[0].Cells[0].Value.ToString());
            var showSponsor = _sponsors.GetById(selectedSponsorIndex);
            var showJumper = _jumpers.GetById(showSponsor.JumperId);


            MessageBox.Show(showJumper.FirstName + " " + showJumper.LastName);
        }

        /// <summary>
        /// edycja danych sponsora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSponsorEdit_Click(object sender, EventArgs e)
        {
            var selectedSponsorIndex = Int32.Parse(dataGridViewSponsors.SelectedRows[0].Cells[0].Value.ToString());
            var showSponsor = _sponsors.GetById(selectedSponsorIndex);

            textBoxSponsorId.Text = showSponsor.Id.ToString();
            textBoxSponsorName.Text = showSponsor.Name.ToString();
            textBoxSponsorCash.Text = showSponsor.Cash.ToString();
            var test = _jumpers.GetAll();
            comboBoxJumper.DataSource = test;
        }

        /// <summary>
        /// zaktualozowanie danych sponsora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSponsorUpdate_Click(object sender, EventArgs e)
        {
            var sponsorName = textBoxSponsorName.Text;
            var sponsorCash = textBoxSponsorCash.Text;
            var sponsorId = Int32.Parse(textBoxSponsorId.Text);
            var sponsorJumper = comboBoxJumper.SelectedIndex + 1;

            Sponsor newSponsor = _sponsors.GetById(sponsorId);

            newSponsor.Id = sponsorId;
            newSponsor.Name = sponsorName;
            newSponsor.Cash = float.Parse(sponsorCash);
            newSponsor.JumperId = sponsorJumper;

            _sponsors.Update(newSponsor);
            _sponsors.Save();
            Load();
        }

        /// <summary>
        /// usunięcie sponsora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSponsorDelete_Click(object sender, EventArgs e)
        {
            var selectedSponsorIndex = Int32.Parse(dataGridViewSponsors.SelectedRows[0].Cells[0].Value.ToString());

            _sponsors.DeleteById(selectedSponsorIndex);
            _sponsors.Save();
            Load();
        }

        /// <summary>
        /// dodanie sponsora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddSponsor_Click(object sender, EventArgs e)
        {
            var sponsorName = textBoxAddSponsorName.Text;
            var sponsorCash = textBoxAddSponsorCash.Text;
            var sponsorJumperId = comboBoxAddSponsorJumper.SelectedIndex + 1;

            Sponsor newSponsor = new Sponsor
            {
                Name = sponsorName,
                Cash = float.Parse(sponsorCash),
                JumperId = sponsorJumperId
            };

            _sponsors.Create(newSponsor);
            _sponsors.Save();
            Load();
        }

        /// <summary>
        /// klikniecie w combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAddSponsorJumper_Click(object sender, EventArgs e)
        {
            var test = _jumpers.GetAll();
            comboBoxAddSponsorJumper.DataSource = test;
        }

        /// <summary>
        /// przycisk pokazuje ile pieniędzy wydał dany sponsor i zapisuje 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSponsor_Click(object sender, EventArgs e)
        {
            var selectedSponsorIndex = Int32.Parse(dataGridViewSponsors.SelectedRows[0].Cells[0].Value.ToString()) - 1;
            var showSalary = _salaries.GetAll();
            float money = 0;
            int id = 0;
            var showSponsor = _sponsors.GetAll();

            for (int i = 0; i < showSponsor.Count; i++)
            {
                if (showSponsor[selectedSponsorIndex].Name == showSponsor[i].Name)
                {
                    money += showSponsor[i].Cash;
                    id = showSponsor[i].Id;
                }
            }

            Salary newSalary = new Salary
            {
                AllCash = money,
                SponsorId = id
            };

            _salaries.Create(newSalary);
            _salaries.Save();
            Load();
            MessageBox.Show(showSponsor[id - 1].Name + " wydał łącznie " + money);
        }

        private void dataGridViewJumpers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

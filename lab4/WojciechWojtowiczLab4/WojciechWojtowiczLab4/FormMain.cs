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

        public FormMain()
        {
            InitializeComponent();
            _jumpers = new SkiJumpingGeneric<Jumper>();
            _countries = new SkiJumpingGeneric<Country>();
            LoadJumpers();
        }

        private void LoadJumpers()
        {
            dataGridViewCountries.DataSource = _countries.GetAll();
            dataGridViewJumpers.DataSource = _jumpers.GetAll();
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
            LoadJumpers();
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
                CountryRecord = Int32.Parse(countryRecord)
            };

            _countries.Create(newCountry);
            _countries.Save();
            LoadJumpers();
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

            LoadJumpers();
        }

        /// <summary>
        /// edycja danych skoczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperUpdate_Click(object sender, EventArgs e)
        {

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
            LoadJumpers();

        }

        /// <summary>
        /// edycja danych kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryUpdate_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// wyświetlanie informacji o kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _countries.GetAll().Count; i++)
            {
                _countries.GetAll()[i].Jumpers = new List<Jumper>();
            }

            for (int i = 0; i < _countries.GetAll().Count ; i++)
            {
                for (int j = 0; j < _jumpers.GetAll().Count; j++)
                {
                    if (_countries.GetAll()[i].Id == _jumpers.GetAll()[j].CountryId)
                    {
                        _countries.GetAll()[i].Jumpers.Add(_jumpers.GetAll()[j]);
                    }
                }
            }
            var selectedCountryIndex = Int32.Parse(dataGridViewCountries.SelectedRows[0].Cells[0].Value.ToString());
            var showCountry = _countries.GetById(selectedCountryIndex);

            MessageBox.Show("Kraj " + showCountry.Name + " posiada " + showCountry.Jumpers.Count + " skoczków");
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
            var jumperUpdatedBirthdate = dateTimePickerJumper.Text;
            var jumperUpdatedCountryId = textBoxUpdateCountryId.Text;
        }
    }
}

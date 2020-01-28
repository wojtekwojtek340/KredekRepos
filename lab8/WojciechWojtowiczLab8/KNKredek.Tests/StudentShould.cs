﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace KNKredek.Tests
{
    public class StudentShould
    {
        private readonly ITestOutputHelper _stdOut;

        public StudentShould(ITestOutputHelper stdOut)
        {
            _stdOut = stdOut;
        }

        [Fact (Skip ="no nie wiem")] //pomijamy ten test        
        public void BeActiveWhenNew()
        {
            _stdOut.WriteLine("Checking student");
            Student sut = new Student(); //system under test

            Assert.True(sut.IsActive);
        }

        [Theory]
        [InlineData("Mirek","Handlarz")]
        [InlineData("Migfdrek", "Handlgfdarz")]
        [InlineData("Miregfk", "Hangfgdlarz")]
        [InlineData("ss", "")]
        [InlineData("fsdfsfsd", "fddds")]
        public void CalculateFullName(string firstName, string lastName)
        {
            Student sut = new Student();

            sut.FirstName = firstName;
            sut.LastName = lastName;

            Assert.Equal(firstName + " " + lastName, sut.FullName, ignoreCase:true);
        }


        [Fact]
        public void CalculateFullNameStartsWithFirstName()
        {
            Student sut = new Student();

            sut.FirstName = "Kot";
            sut.LastName = "Student";

            Assert.StartsWith("Kot", sut.FullName);
        }

        [Fact]
        public void CalculateFullNameEndsWithFirstName()
        {
            Student sut = new Student();

            sut.FirstName = "Kot";
            sut.LastName = "Student";

            Assert.EndsWith("Student", sut.FullName);
        }

        [Fact]
        public void CalculateFullName_Contains()
        {
            Student sut = new Student();

            sut.FirstName = "Mirek";
            sut.LastName = "Handlarz";

            Assert.Contains("Mirek Ha", sut.FullName);
        }

        [Fact]
        public void CalculateStudentMotivation()
        {
            Student sut = new Student();

            sut.Motivation = 100;

            Assert.Equal(100, sut.Motivation);
        }

        [Fact]
        public void CalculateStudentMotivationRandom()
        {
            Student sut = new Student();

            sut.Motivation = 80;

            Assert.NotEqual(100, sut.Motivation);
        }

        [Fact]
        public void CalculateStudentMotivationRandomRest()
        {
            Student sut = new Student();

            sut.Rest();

            Assert.InRange(sut.Motivation,101,150);
        }

        [Fact]
        public void CalculateStudentMotivation2()
        {
            Student sut = new Student();

            sut.Rest();

            Assert.True(sut.Motivation >= 101 && sut.Motivation <= 150);
        }

        [Fact]
        public void CalculateStudentIndex()
        {
            Student sut = new Student();

            sut.SetRandomIndexNumber();

            Assert.NotNull(sut.IndexNumber);
        }

        [Fact]
        public void RaiseRestEvent()
        {
            Student sut = new Student();

            Assert.Raises<EventArgs>(
                handler => sut.StudentRest += handler,
                handler => sut.StudentRest -= handler,
                () => sut.Rest());
        }

        [Fact]
        public void RaisePropertyChangeEvent()
        {
            Student sut = new Student();

            Assert.PropertyChanged(sut, "Motivation", () => sut.TakeAllTheCodeIn2Hours());
        }
    }
}

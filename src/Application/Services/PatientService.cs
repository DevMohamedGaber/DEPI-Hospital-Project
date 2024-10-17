﻿using Application.Interfaces;
using DataAccess.Data;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Shared.DTO;
using Shared.Enums;
using System.Net;


namespace Application.Services
{
    public class PatientService : IPatientService
    {
        IPatientRepository repository;
        public PatientService(IPatientRepository repository)
        {
            this.repository = repository;
        }

        public bool AddNewPatient(PatientViewModel patient)
        {
            // TODO: Add social number validation
            repository.Create(new Patient
            {
                firstName = patient.firstName,
                lastName = patient.lastName,
                SocialNumber = patient.SocialNumber,
                gender = patient.gender,
                Address = patient.Address,
                PhoneNumber = patient.PhoneNumber,
                EmergencyContactName = patient.EmergencyContactName,
                EmergencyContactRelationship = patient.EmergencyContactRelationship,
                EmergencyContactPhone = patient.EmergencyContactPhone
            });
            return true;
        }

        public IEnumerable<Patient> GetAllPatients(Patient patient)
        {
            return repository.GetAll().ToList();
        }

        public Patient GetPatient(uint id)
        {
            return repository.GetById((int)id);
        }

        public Patient GetPatientBySocialNumber(PatientSignInViewModel model)
        {
            var patient = repository.GetAll().FirstOrDefault(p => p.SocialNumber == model.SocialNumber);
            return patient;
        }

        public bool RemovePatient(uint id)
        {
            var p = repository.GetById((int)id);
            repository.Delete(p);
            return true;
        }

        public bool UpdatePatient(Patient patient)
        {
            var p = repository.GetById((int)patient.Id);
            if(p == null)
            {
                return false;
            }
            repository.Update(patient);
            return true;
        }
    }
}

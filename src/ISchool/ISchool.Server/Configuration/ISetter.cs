﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ISchool.Server.Configuration
{
    [ServiceContract]
    public interface ISetter
    {
        [OperationContract]
        int PutTeacher(string UserName, string RealyName, string Password, bool IsAdmin = false);
        [OperationContract]
        int PutStudent(string StudentAcc, string Name, string Specialization, string Nationality, string NationalId, string EnterDate, int AcademicSupervisor);
        [OperationContract]
        int PutSchedualForStudent(int StudentId, int Sub1, int Sub2, int Sub3, int Sub4, int Sub5, int Sub6, int Sub7, int Sub8);
        [OperationContract]
        int PutNotification(int SenderId, string Title, string NotificationBody, int ToUser);
        [OperationContract]
        int PutSubject(int TeacherId, string Type, string Class, string Place);
        [OperationContract]
        int PutAbsence(int StudentId, int AbsenceType, DateTime Date, int Subject);
        [OperationContract]
        int PutExcuse(int AbsenceId, int ByUserId, string Excuse, DateTime EnterDate);
        [OperationContract]
        int ChangeStudentPhoneNumber(int StudentId, string PhoneNumber);
    }
}

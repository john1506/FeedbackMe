﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("FeedbackAppModel", "FK_feedback_Lecturers", "Lecturers", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(FeedbackMe.Web.Lecturer), "feedback", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(FeedbackMe.Web.feedback), true)]
[assembly: EdmRelationshipAttribute("FeedbackAppModel", "FK_feedback_modules", "modules", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(FeedbackMe.Web.module), "feedback", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(FeedbackMe.Web.feedback), true)]
[assembly: EdmRelationshipAttribute("FeedbackAppModel", "FK_feedback_students", "students", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(FeedbackMe.Web.student), "feedback", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(FeedbackMe.Web.feedback), true)]

#endregion

namespace FeedbackMe.Web
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class FeedbackAppEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new FeedbackAppEntities object using the connection string found in the 'FeedbackAppEntities' section of the application configuration file.
        /// </summary>
        public FeedbackAppEntities() : base("name=FeedbackAppEntities", "FeedbackAppEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FeedbackAppEntities object.
        /// </summary>
        public FeedbackAppEntities(string connectionString) : base(connectionString, "FeedbackAppEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FeedbackAppEntities object.
        /// </summary>
        public FeedbackAppEntities(EntityConnection connection) : base(connection, "FeedbackAppEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<feedback> feedbacks
        {
            get
            {
                if ((_feedbacks == null))
                {
                    _feedbacks = base.CreateObjectSet<feedback>("feedbacks");
                }
                return _feedbacks;
            }
        }
        private ObjectSet<feedback> _feedbacks;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Lecturer> Lecturers
        {
            get
            {
                if ((_Lecturers == null))
                {
                    _Lecturers = base.CreateObjectSet<Lecturer>("Lecturers");
                }
                return _Lecturers;
            }
        }
        private ObjectSet<Lecturer> _Lecturers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<module> modules
        {
            get
            {
                if ((_modules == null))
                {
                    _modules = base.CreateObjectSet<module>("modules");
                }
                return _modules;
            }
        }
        private ObjectSet<module> _modules;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<student> students
        {
            get
            {
                if ((_students == null))
                {
                    _students = base.CreateObjectSet<student>("students");
                }
                return _students;
            }
        }
        private ObjectSet<student> _students;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<user> users
        {
            get
            {
                if ((_users == null))
                {
                    _users = base.CreateObjectSet<user>("users");
                }
                return _users;
            }
        }
        private ObjectSet<user> _users;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the feedbacks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTofeedbacks(feedback feedback)
        {
            base.AddObject("feedbacks", feedback);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Lecturers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLecturers(Lecturer lecturer)
        {
            base.AddObject("Lecturers", lecturer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the modules EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTomodules(module module)
        {
            base.AddObject("modules", module);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the students EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTostudents(student student)
        {
            base.AddObject("students", student);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTousers(user user)
        {
            base.AddObject("users", user);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FeedbackAppModel", Name="feedback")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class feedback : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new feedback object.
        /// </summary>
        /// <param name="fID">Initial value of the FID property.</param>
        /// <param name="studentID">Initial value of the studentID property.</param>
        /// <param name="moduleID">Initial value of the moduleID property.</param>
        /// <param name="teacherID">Initial value of the teacherID property.</param>
        /// <param name="feedback1">Initial value of the Feedback1 property.</param>
        /// <param name="lectureRating">Initial value of the lectureRating property.</param>
        public static feedback Createfeedback(global::System.Int32 fID, global::System.Int32 studentID, global::System.Int32 moduleID, global::System.Int32 teacherID, global::System.String feedback1, global::System.Int32 lectureRating)
        {
            feedback feedback = new feedback();
            feedback.FID = fID;
            feedback.studentID = studentID;
            feedback.moduleID = moduleID;
            feedback.teacherID = teacherID;
            feedback.Feedback1 = feedback1;
            feedback.lectureRating = lectureRating;
            return feedback;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 FID
        {
            get
            {
                return _FID;
            }
            set
            {
                if (_FID != value)
                {
                    OnFIDChanging(value);
                    ReportPropertyChanging("FID");
                    _FID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("FID");
                    OnFIDChanged();
                }
            }
        }
        private global::System.Int32 _FID;
        partial void OnFIDChanging(global::System.Int32 value);
        partial void OnFIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 studentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                OnstudentIDChanging(value);
                ReportPropertyChanging("studentID");
                _studentID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("studentID");
                OnstudentIDChanged();
            }
        }
        private global::System.Int32 _studentID;
        partial void OnstudentIDChanging(global::System.Int32 value);
        partial void OnstudentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 moduleID
        {
            get
            {
                return _moduleID;
            }
            set
            {
                OnmoduleIDChanging(value);
                ReportPropertyChanging("moduleID");
                _moduleID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("moduleID");
                OnmoduleIDChanged();
            }
        }
        private global::System.Int32 _moduleID;
        partial void OnmoduleIDChanging(global::System.Int32 value);
        partial void OnmoduleIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 teacherID
        {
            get
            {
                return _teacherID;
            }
            set
            {
                OnteacherIDChanging(value);
                ReportPropertyChanging("teacherID");
                _teacherID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("teacherID");
                OnteacherIDChanged();
            }
        }
        private global::System.Int32 _teacherID;
        partial void OnteacherIDChanging(global::System.Int32 value);
        partial void OnteacherIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Feedback1
        {
            get
            {
                return _Feedback1;
            }
            set
            {
                OnFeedback1Changing(value);
                ReportPropertyChanging("Feedback1");
                _Feedback1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Feedback1");
                OnFeedback1Changed();
            }
        }
        private global::System.String _Feedback1;
        partial void OnFeedback1Changing(global::System.String value);
        partial void OnFeedback1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 lectureRating
        {
            get
            {
                return _lectureRating;
            }
            set
            {
                OnlectureRatingChanging(value);
                ReportPropertyChanging("lectureRating");
                _lectureRating = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("lectureRating");
                OnlectureRatingChanged();
            }
        }
        private global::System.Int32 _lectureRating;
        partial void OnlectureRatingChanging(global::System.Int32 value);
        partial void OnlectureRatingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private Nullable<global::System.DateTime> _date;
        partial void OndateChanging(Nullable<global::System.DateTime> value);
        partial void OndateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FeedbackAppModel", "FK_feedback_Lecturers", "Lecturers")]
        public Lecturer Lecturer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Lecturer>("FeedbackAppModel.FK_feedback_Lecturers", "Lecturers").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Lecturer>("FeedbackAppModel.FK_feedback_Lecturers", "Lecturers").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Lecturer> LecturerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Lecturer>("FeedbackAppModel.FK_feedback_Lecturers", "Lecturers");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Lecturer>("FeedbackAppModel.FK_feedback_Lecturers", "Lecturers", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FeedbackAppModel", "FK_feedback_modules", "modules")]
        public module module
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<module>("FeedbackAppModel.FK_feedback_modules", "modules").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<module>("FeedbackAppModel.FK_feedback_modules", "modules").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<module> moduleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<module>("FeedbackAppModel.FK_feedback_modules", "modules");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<module>("FeedbackAppModel.FK_feedback_modules", "modules", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FeedbackAppModel", "FK_feedback_students", "students")]
        public student student
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<student>("FeedbackAppModel.FK_feedback_students", "students").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<student>("FeedbackAppModel.FK_feedback_students", "students").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<student> studentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<student>("FeedbackAppModel.FK_feedback_students", "students");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<student>("FeedbackAppModel.FK_feedback_students", "students", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FeedbackAppModel", Name="Lecturer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Lecturer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Lecturer object.
        /// </summary>
        /// <param name="teacherID">Initial value of the teacherID property.</param>
        /// <param name="teacherFirstName">Initial value of the teacherFirstName property.</param>
        /// <param name="teacherLastName">Initial value of the teacherLastName property.</param>
        public static Lecturer CreateLecturer(global::System.Int32 teacherID, global::System.String teacherFirstName, global::System.String teacherLastName)
        {
            Lecturer lecturer = new Lecturer();
            lecturer.teacherID = teacherID;
            lecturer.teacherFirstName = teacherFirstName;
            lecturer.teacherLastName = teacherLastName;
            return lecturer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 teacherID
        {
            get
            {
                return _teacherID;
            }
            set
            {
                if (_teacherID != value)
                {
                    OnteacherIDChanging(value);
                    ReportPropertyChanging("teacherID");
                    _teacherID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("teacherID");
                    OnteacherIDChanged();
                }
            }
        }
        private global::System.Int32 _teacherID;
        partial void OnteacherIDChanging(global::System.Int32 value);
        partial void OnteacherIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String teacherFirstName
        {
            get
            {
                return _teacherFirstName;
            }
            set
            {
                OnteacherFirstNameChanging(value);
                ReportPropertyChanging("teacherFirstName");
                _teacherFirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("teacherFirstName");
                OnteacherFirstNameChanged();
            }
        }
        private global::System.String _teacherFirstName;
        partial void OnteacherFirstNameChanging(global::System.String value);
        partial void OnteacherFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String teacherLastName
        {
            get
            {
                return _teacherLastName;
            }
            set
            {
                OnteacherLastNameChanging(value);
                ReportPropertyChanging("teacherLastName");
                _teacherLastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("teacherLastName");
                OnteacherLastNameChanged();
            }
        }
        private global::System.String _teacherLastName;
        partial void OnteacherLastNameChanging(global::System.String value);
        partial void OnteacherLastNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FeedbackAppModel", "FK_feedback_Lecturers", "feedback")]
        public EntityCollection<feedback> feedbacks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<feedback>("FeedbackAppModel.FK_feedback_Lecturers", "feedback");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<feedback>("FeedbackAppModel.FK_feedback_Lecturers", "feedback", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FeedbackAppModel", Name="module")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class module : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new module object.
        /// </summary>
        /// <param name="moduleID">Initial value of the moduleID property.</param>
        /// <param name="moduleName">Initial value of the moduleName property.</param>
        /// <param name="moduleCode">Initial value of the moduleCode property.</param>
        public static module Createmodule(global::System.Int32 moduleID, global::System.String moduleName, global::System.String moduleCode)
        {
            module module = new module();
            module.moduleID = moduleID;
            module.moduleName = moduleName;
            module.moduleCode = moduleCode;
            return module;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 moduleID
        {
            get
            {
                return _moduleID;
            }
            set
            {
                if (_moduleID != value)
                {
                    OnmoduleIDChanging(value);
                    ReportPropertyChanging("moduleID");
                    _moduleID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("moduleID");
                    OnmoduleIDChanged();
                }
            }
        }
        private global::System.Int32 _moduleID;
        partial void OnmoduleIDChanging(global::System.Int32 value);
        partial void OnmoduleIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String moduleName
        {
            get
            {
                return _moduleName;
            }
            set
            {
                OnmoduleNameChanging(value);
                ReportPropertyChanging("moduleName");
                _moduleName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("moduleName");
                OnmoduleNameChanged();
            }
        }
        private global::System.String _moduleName;
        partial void OnmoduleNameChanging(global::System.String value);
        partial void OnmoduleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String moduleCode
        {
            get
            {
                return _moduleCode;
            }
            set
            {
                OnmoduleCodeChanging(value);
                ReportPropertyChanging("moduleCode");
                _moduleCode = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("moduleCode");
                OnmoduleCodeChanged();
            }
        }
        private global::System.String _moduleCode;
        partial void OnmoduleCodeChanging(global::System.String value);
        partial void OnmoduleCodeChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FeedbackAppModel", "FK_feedback_modules", "feedback")]
        public EntityCollection<feedback> feedbacks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<feedback>("FeedbackAppModel.FK_feedback_modules", "feedback");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<feedback>("FeedbackAppModel.FK_feedback_modules", "feedback", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FeedbackAppModel", Name="student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new student object.
        /// </summary>
        /// <param name="studentID">Initial value of the studentID property.</param>
        /// <param name="studentFName">Initial value of the studentFName property.</param>
        /// <param name="studentLName">Initial value of the studentLName property.</param>
        /// <param name="courseID">Initial value of the courseID property.</param>
        public static student Createstudent(global::System.Int32 studentID, global::System.String studentFName, global::System.String studentLName, global::System.Int32 courseID)
        {
            student student = new student();
            student.studentID = studentID;
            student.studentFName = studentFName;
            student.studentLName = studentLName;
            student.courseID = courseID;
            return student;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 studentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                if (_studentID != value)
                {
                    OnstudentIDChanging(value);
                    ReportPropertyChanging("studentID");
                    _studentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("studentID");
                    OnstudentIDChanged();
                }
            }
        }
        private global::System.Int32 _studentID;
        partial void OnstudentIDChanging(global::System.Int32 value);
        partial void OnstudentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String studentFName
        {
            get
            {
                return _studentFName;
            }
            set
            {
                OnstudentFNameChanging(value);
                ReportPropertyChanging("studentFName");
                _studentFName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("studentFName");
                OnstudentFNameChanged();
            }
        }
        private global::System.String _studentFName;
        partial void OnstudentFNameChanging(global::System.String value);
        partial void OnstudentFNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String studentLName
        {
            get
            {
                return _studentLName;
            }
            set
            {
                OnstudentLNameChanging(value);
                ReportPropertyChanging("studentLName");
                _studentLName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("studentLName");
                OnstudentLNameChanged();
            }
        }
        private global::System.String _studentLName;
        partial void OnstudentLNameChanging(global::System.String value);
        partial void OnstudentLNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 courseID
        {
            get
            {
                return _courseID;
            }
            set
            {
                OncourseIDChanging(value);
                ReportPropertyChanging("courseID");
                _courseID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("courseID");
                OncourseIDChanged();
            }
        }
        private global::System.Int32 _courseID;
        partial void OncourseIDChanging(global::System.Int32 value);
        partial void OncourseIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FeedbackAppModel", "FK_feedback_students", "feedback")]
        public EntityCollection<feedback> feedbacks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<feedback>("FeedbackAppModel.FK_feedback_students", "feedback");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<feedback>("FeedbackAppModel.FK_feedback_students", "feedback", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FeedbackAppModel", Name="user")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class user : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new user object.
        /// </summary>
        /// <param name="studentID">Initial value of the studentID property.</param>
        /// <param name="studentName">Initial value of the studentName property.</param>
        /// <param name="password">Initial value of the password property.</param>
        public static user Createuser(global::System.Int32 studentID, global::System.String studentName, global::System.String password)
        {
            user user = new user();
            user.studentID = studentID;
            user.studentName = studentName;
            user.password = password;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 studentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                if (_studentID != value)
                {
                    OnstudentIDChanging(value);
                    ReportPropertyChanging("studentID");
                    _studentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("studentID");
                    OnstudentIDChanged();
                }
            }
        }
        private global::System.Int32 _studentID;
        partial void OnstudentIDChanging(global::System.Int32 value);
        partial void OnstudentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String studentName
        {
            get
            {
                return _studentName;
            }
            set
            {
                if (_studentName != value)
                {
                    OnstudentNameChanging(value);
                    ReportPropertyChanging("studentName");
                    _studentName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("studentName");
                    OnstudentNameChanged();
                }
            }
        }
        private global::System.String _studentName;
        partial void OnstudentNameChanging(global::System.String value);
        partial void OnstudentNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password != value)
                {
                    OnpasswordChanging(value);
                    ReportPropertyChanging("password");
                    _password = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("password");
                    OnpasswordChanged();
                }
            }
        }
        private global::System.String _password;
        partial void OnpasswordChanging(global::System.String value);
        partial void OnpasswordChanged();

        #endregion
    
    }

    #endregion
    
}

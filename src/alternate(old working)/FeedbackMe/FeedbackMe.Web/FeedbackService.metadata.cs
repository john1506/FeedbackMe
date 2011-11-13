
namespace FeedbackMe.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies feedbackMetadata as the class
    // that carries additional metadata for the feedback class.
    [MetadataTypeAttribute(typeof(feedback.feedbackMetadata))]
    public partial class feedback
    {

        // This class allows you to attach custom attributes to properties
        // of the feedback class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class feedbackMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private feedbackMetadata()
            {
            }

            public Nullable<DateTime> date { get; set; }

            public string Feedback1 { get; set; }

            public int FID { get; set; }

            public Lecturer Lecturer { get; set; }

            public int lectureRating { get; set; }

            public module module { get; set; }

            public int moduleID { get; set; }

            public student student { get; set; }

            public int studentID { get; set; }

            public int teacherID { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies LecturerMetadata as the class
    // that carries additional metadata for the Lecturer class.
    [MetadataTypeAttribute(typeof(Lecturer.LecturerMetadata))]
    public partial class Lecturer
    {

        // This class allows you to attach custom attributes to properties
        // of the Lecturer class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class LecturerMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private LecturerMetadata()
            {
            }

            public EntityCollection<feedback> feedbacks { get; set; }

            public string teacherFirstName { get; set; }

            public int teacherID { get; set; }

            public string teacherLastName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies moduleMetadata as the class
    // that carries additional metadata for the module class.
    [MetadataTypeAttribute(typeof(module.moduleMetadata))]
    public partial class module
    {

        // This class allows you to attach custom attributes to properties
        // of the module class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class moduleMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private moduleMetadata()
            {
            }

            public EntityCollection<feedback> feedbacks { get; set; }

            public string moduleCode { get; set; }

            public int moduleID { get; set; }

            public string moduleName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies studentMetadata as the class
    // that carries additional metadata for the student class.
    [MetadataTypeAttribute(typeof(student.studentMetadata))]
    public partial class student
    {

        // This class allows you to attach custom attributes to properties
        // of the student class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class studentMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private studentMetadata()
            {
            }

            public int courseID { get; set; }

            public EntityCollection<feedback> feedbacks { get; set; }

            public string studentFName { get; set; }

            public int studentID { get; set; }

            public string studentLName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies userMetadata as the class
    // that carries additional metadata for the user class.
    [MetadataTypeAttribute(typeof(user.userMetadata))]
    public partial class user
    {

        // This class allows you to attach custom attributes to properties
        // of the user class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class userMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private userMetadata()
            {
            }

            public string password { get; set; }

            public int studentID { get; set; }

            public string studentName { get; set; }
        }
    }
}

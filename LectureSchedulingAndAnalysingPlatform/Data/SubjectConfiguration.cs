using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(
           new Subject
           {
               Id = 1,
               Name = "Introduction to Civil Engineering",
               Code = "CE1301"
           },

            new Subject
            {
                Id = 2,
                Name = "Mechanics of Materials",
                Code = "CE2302"
            },
            new Subject
            {
                Id = 3,
                Name = "Fundamentals of Fluid Mechanics",
                Code = "CE2201"
            },
            new Subject
            {
                Id = 4,
                Name = "Building Planning and Cost Estimating",
                Code = "CE3301"
            },
            new Subject
            {
                Id = 5,
                Name = "Concrete Technology",
                Code = "CE3202"
            },
            new Subject
            {
                Id = 6,
                Name = "Engineering Surveying",
                Code = "CE3203"
            },
            new Subject
            {
                Id = 7,
                Name = "Fluid Mechanics",
                Code = "CE3304"
            },
            new Subject
            {
                Id = 8,
                Name = "Structural Analysis I",
                Code = "CE3205"
            },
            new Subject
            {
                Id = 9,
                Name = "Design of Concrete Structures I",
                Code = "CE4301"
            },
            new Subject
            {
                Id = 10,
                Name = "Engineering Geology and Soil Mechanics",
                Code = "CE4302"
            },
            new Subject
            {
                Id = 11,
                Name = "Structural Analysis II",
                Code = "CE4203"
            },
            new Subject
            {
                Id = 12,
                Name = "Transportation Engineering",
                Code = "CE4304"
            },
            new Subject
            {
                Id = 13,
                Name = "Water and Wastewater Engineering",
                Code = "CE4305"
            },
            new Subject
            {
                Id = 14,
                Name = "Design of Steel Structures",
                Code = "CE5201"
            },
            new Subject
            {
                Id = 15,
                Name = "Highway Engineering Design",
                Code = "CE5302"
            },
            new Subject
            {
                Id = 16,
                Name = "Hydraulic Engineering",
                Code = "CE5303"
            },
            new Subject
            {
                Id = 17,
                Name = "Structural Analysis III",
                Code = "CE5204"
            },
            new Subject
            {
                Id = 18,
                Name = "Design of Timber and Masonry Structures (TE)",
                Code = "CE5251"
            },
           
          
          
            new Subject
            {
                Id = 23,
                Name = "Construction Processes and Technology",
                Code = "CE6301"
            },
            new Subject
            {
                Id = 24,
                Name = "Design of Concrete structures II",
                Code = "CE6302"
            },
            new Subject
            {
                Id = 25,
                Name = "Engineering Hydrology",
                Code = "CE6303"
            },
            new Subject
            {
                Id = 26,
                Name = "Environmental Engineering Design",
                Code = "CE6304"
            },
            new Subject
            {
                Id = 27,
                Name = "Geotechnical Engineering",
                Code = "CE6305"
            },
            new Subject
            {
                Id = 28,
                Name = "Surveying Work Camp",
                Code = "CE6106"
            },
          
            new Subject
            {
                Id = 33,
                Name = "Construction Management",
                Code = "CE7301"
            },
            new Subject
            {
                Id = 34,
                Name = "Comprehensive Design Project",
                Code = "CE7402"
            },
            new Subject
            {
                Id = 35,
                Name = "Computer Analysis of Structures",
                Code = "CE7203"
            },
            new Subject
            {
                Id = 36,
                Name = "Environmental Management",
                Code = "CE7304"
            },
            new Subject
            {
                Id = 37,
                Name = "Geotechnical Engineering Design",
                Code = "CE7305"
            },
            new Subject
            {
                Id = 38,
                Name = "Introduction to Research Methodology",
                Code = "CE7206"
            },
            new Subject
            {
                Id = 39,
                Name = "Undergraduate Research Project",
                Code = "CE7607"
            },
          
                     new Subject
                       {
                           Id = 44,
                           Name = "Irrigation and Watershed Management (TE)",
                           Code = "CE8252"
                       },
            new Subject
            {
                Id = 45,
                Name = "Water Resource Planning and Management (TE)",
                Code = "CE8253"
            },
            new Subject
            {
                Id = 46,
                Name = "Analysis and Design of Large Structures for Dynamic Loadings (TE)",
                Code = "CE8254"
            },

            new Subject
            {
                Id = 47,
                Name = "Introduction to Programming",
                Code = "EE1102"
            },
            new Subject
            {
                Id = 48,
                Name = "Object Oriented Programming",
                Code = "EE2201"
            },
            new Subject
            {
                Id = 49,
                Name = "Introduction to Electronic Engineering",
                Code = "EE2202"
            },
            new Subject
            {
                Id = 50,
                Name = "Analog Electronics",
                Code = "EE3301"
            },
            new Subject
            {
                Id = 51,
                Name = "Engineering Electromagnetism",
                Code = "EE3302"
            },
            new Subject
            {
                Id = 52,
                Name = "Electric Machines",
                Code = "EE3303"
            },
            new Subject
            {
                Id = 53,
                Name = "Graphical User Interface Programming",
                Code = "EE3204"
            },
            new Subject
            {
                Id = 54,
                Name = "Signals and Systems",
                Code = "EE3205"
            },
          
            new Subject
            {
                Id = 56,
                Name = "Electronic Project",
                Code = "EE3108"
            },
            new Subject
            {
                Id = 57,
                Name = "Communication Theory",
                Code = "EE4301"
            },
            new Subject
            {
                Id = 58,
                Name = "Digital Electronics",
                Code = "EE4302"
            },
            new Subject
            {
                Id = 59,
                Name = "Data Structures and Algorithms",
                Code = "EE4303"
            },
            new Subject
            {
                Id = 60,
                Name = "Electrical and Electronic Measurements",
                Code = "EE4204"
            },
            new Subject
            {
                Id = 61,
                Name = "Power Systems",
                Code = "EE4305"
            },
            new Subject
            {
                Id = 62,
                Name = "Software Engineering Principles",
                Code = "EE4106"
            },
            new Subject
            {
                Id = 63,
                Name = "Computer Architecture",
                Code = "EE5201"
            },
            new Subject
            {
                Id = 64,
                Name = "Computer Networks",
                Code = "EE5302"
            },
            new Subject
            {
                Id = 65,
                Name = "Data Management Systems",
                Code = "EE5203"
            },
            new Subject
            {
                Id = 66,
                Name = "Power Electronics",
                Code = "EE5304"
            },
            new Subject
            {
                Id = 67,
                Name = "Sensors, Transducers and Measurement Techniques",
                Code = "EE5305"
            },
            new Subject
            {
                Id = 68,
                Name = "Software Project",
                Code = "EE5206"
            },
            
            new Subject
            {
                Id = 70,
                Name = "Electronic Circuit Design (TE)",
                Code = "EE5208"
            },
            new Subject
            {
                Id = 71,
                Name = "Communication Systems",
                Code = "EE6301"
            },
            new Subject
            {
                Id = 72,
                Name = "Control System Design",
                Code = "EE6302"
            },
            new Subject
            {
                Id = 73,
                Name = "Electric Machines and Drives",
                Code = "EE6303"
            },
            new Subject
            {
                Id = 74,
                Name = "Embedded System Design",
                Code = "EE6304"
            },
            new Subject
            {
                Id = 75,
                Name = "Energy and Environment",
                Code = "EE6205"
            },
            new Subject
            {
                Id = 76,
                Name = "Operating Systems Programming (TE)",
                Code = "EE6206"
            },
            new Subject
            {
                Id = 77,
                Name = "Wireless and Mobile Communication (TE)",
                Code = "EE6207"
            },
            new Subject
            {
                Id = 78,
                Name = "Undergraduate Project",
                Code = "EE7601"
            },
                        new Subject
                        {
                            Id = 85,
                            Name = "Computer Vision and Image Processing (TE)",
                            Code = "EE7207"
                        },

          new Subject
          {
              Id = 86,
              Name = "Advanced Data Communication (TE)",
              Code = "EE7208"
          },
            new Subject
            {
                Id = 87,
                Name = "Digital Signal Processing (TE)",
                Code = "EE7209"
            },
            new Subject
            {
                Id = 88,
                Name = "Telecommunication Networks (TE)",
                Code = "EE7210"
            },
            new Subject
            {
                Id = 89,
                Name = "Optical Fiber Communication (TE)",
                Code = "EE7211"
            },


            new Subject
            {
                Id = 90,
                Name = "EE 7212 Introduction to Research (TE)",
                Code = "EE7212"
            },
            new Subject
            {
                Id = 91,
                Name = "High Voltage Engineering (TE)",
                Code = "EE8301"
            },
           
            new Subject
            {
                Id = 94,
                Name = "Information Security (TE)",
                Code = "EE8204"
            },
            new Subject
            {
                Id = 95,
                Name = "Software Architecture (TE)",
                Code = "EE8205 "
            },
            new Subject
            {
                Id = 96,
                Name = "Computer Graphics (TE)",
                Code = "EE8206 "
            },
            new Subject
            {
                Id = 97,
                Name = "Optimization Techniques for Engineers (TE)",
                Code = "EE8207 "
            },
            
            new Subject
            {
                Id = 106,
                Name = "Fundamentals of Engineering Thermodynamics",
                Code = "ME1202"
            },
            new Subject
            {
                Id = 107,
                Name = "Introduction to Materials Science and Manufacturing Engineering",
                Code = "ME2302"
            },
            new Subject
            {
                Id = 108,
                Name = "Fluid Mechanics",
                Code = "ME3301"
            },
            new Subject
            {
                Id = 109,
                Name = "Metallurgy for Engineers",
                Code = "ME3302"
            },
            new Subject
            {
                Id = 110,
                Name = "Modelling of Dynamic Systems",
                Code = "ME3303"
            },
            new Subject
            {
                Id = 111,
                Name = "Strength of Materials",
                Code = "ME3304"
            },
            new Subject
            {
                Id = 112,
                Name = "Engineering Design Methodology (TE)",
                Code = "ME3111"
            },
            new Subject
            {
                Id = 113,
                Name = "Applied Thermodynamics",
                Code = "ME4301"
            },
            new Subject
            {
                Id = 114,
                Name = "Design of Machine Elements",
                Code = "ME4302"
            },
            new Subject
            {
                Id = 115,
                Name = "Manufacturing Engineering",
                Code = "ME4303"
            },
            new Subject
            {
                Id = 116,
                Name = "Mechanics of Machines",
                Code = "ME4304"
            },
            new Subject
            {
                Id = 117,
                Name = "Analog and Digital Electronics (TE)",
                Code = "ME4311"
            },
            
            new Subject
            {
                Id = 119,
                Name = "Computer Aided Design",
                Code = "ME5301"
            },
            new Subject
            {
                Id = 120,
                Name = "Electrical Power and Machines",
                Code = "ME5302"
            },
            new Subject
            {
                Id = 121,
                Name = "Mechanical Engineering Design",
                Code = "ME5303"
            },
            new Subject
            {
                Id = 122,
                Name = "Refrigeration and Air Conditioning",
                Code = "ME5304"
            },
            new Subject
            {
                Id = 123,
                Name = "Mechatronics (TE)",
                Code = "ME5311"
            },
            new Subject
            {
                Id = 124,
                Name = "Marine Engineering Knowledge (TE)",
                Code = "ME5312"
            },
            new Subject
            {
                Id = 125,
                Name = "Technical Report Writing (TE)",
                Code = "ME5113"
            },
            new Subject
            {
                Id = 126,
                Name = "Advanced Automobile Engineering (TE)",
                Code = "ME5214"
            },
            new Subject
            {
                Id = 127,
                Name = "Advanced Fluid Mechanics",
                Code = "ME6301"
            },
            new Subject
            {
                Id = 128,
                Name = "Automatic Control Engineering",
                Code = "ME6302"
            },
            new Subject
            {
                Id = 129,
                Name = "Computer Aided Manufacturing",
                Code = "ME6303"
            },
            new Subject
            {
                Id = 130,
                Name = "Production Planning and control",
                Code = "ME6304"
            },
            new Subject
            {
                Id = 131,
                Name = "Nanotechnology (TE)",
                Code = "ME6211"
            },
            new Subject
            {
                Id = 132,
                Name = "Robotics (TE)",
                Code = "ME6312"
            },
            new Subject
            {
                Id = 133,
                Name = "Research Methodology and Ethics (TE)",
                Code = "ME6213"
            },
        
            new Subject
            {
                Id = 135,
                Name = "Maintenance Management",
                Code = "ME7301"
            },
            new Subject
            {
                Id = 136,
                Name = "Production and Operations Management",
                Code = "ME7302"
            },
            new Subject
            {
                Id = 137,
                Name = "Solid Mechanics ",
                Code = "ME7303"
            },
            new Subject
            {
                Id = 138,
                Name = "Undergraduate Project",
                Code = "ME7604"
            },
            new Subject
            {
                Id = 139,
                Name = "Advanced Marine Engineering (TE)",
                Code = "ME7311"
            },
            new Subject
            {
                Id = 140,
                Name = "Energy Technology (TE)",
                Code = "ME7312"
            },
            new Subject
            {
                Id = 143,
                Name = "Heat Transfer",
                Code = "ME8301"
            },
            new Subject
            {
                Id = 144,
                Name = "Industrial Fluid Dynamics",
                Code = "ME8302"
            },
              new Subject
              {
                  Id = 145,
                  Name = "Aerospace Engineering (TE)",
                  Code = "ME8311"
              },
            new Subject
            {
                Id = 146,
                Name = "Energy Management (TE)",
                Code = "ME8312"
            },
            new Subject
            {
                Id = 147,
                Name = "Biomedical Engineering (TE)",
                Code = "EE8212"
            },
            new Subject
            {
                Id = 148,
                Name = "Individual Research Project (TE)",
                Code = "ME8213"
            },

            new Subject
            {
                Id = 149,
                Name = "Communication for Engineers",
                Code = "IS1302"
            },
            new Subject
            {
                Id = 150,
                Name = "Mathematical Fundamentals for Engineers",
                Code = "IS1401"
            },
            new Subject
            {
                Id = 151,
                Name = "Linear Algebra and Differential Equations",
                Code = "IS2401"
            },
            new Subject
            {
                Id = 152,
                Name = "Complex Analysis and Mathematical Transforms",
                Code = "IS3301"
            },
            new Subject
            {
                Id = 153,
                Name = "Society and the Engineer (GE)",
                Code = "IS3302"
            },
            new Subject
            {
                Id = 154,
                Name = "Basic Economics (GE)",
                Code = "IS3303"
            },
            new Subject
            {
                Id = 155,
                Name = "Graphic Design (GE)",
                Code = "IS3104"
            },
            new Subject
            {
                Id = 156,
                Name = "Creative Dance and Oriental Ballet (GE)",
                Code = "IS3105"
            },
            new Subject
            {
                Id = 157,
                Name = "Physical Development and Health Management (GE)",
                Code = "IS3206"
            },
            new Subject
            {
                Id = 158,
                Name = "Introduction to Astronomy (GE)",
                Code = "IS3207"
            },
            new Subject
            {
                Id = 159,
                Name = "Probability and Statistics",
                Code = "IS4301"
            },
            new Subject
            {
                Id = 160,
                Name = "Technology and Society (GE)",
                Code = "IS4302"
            },
            new Subject
            {
                Id = 161,
                Name = "Appreciation of Music (GE)",
                Code = "IS4103"
            },
            new Subject
            {
                Id = 162,
                Name = "Digital Modelling and Animation (GE)",
                Code = "IS4104"
            },
            new Subject
            {
                Id = 163,
                Name = "Aesthetics and Design (GE)",
                Code = "IS4205"
            },
            new Subject
            {
                Id = 164,
                Name = "Spiritual Development (GE)",
                Code = "IS4106"
            },
            new Subject
            {
                Id = 165,
                Name = "Numerical Methods",
                Code = "IS5301"
            },
            new Subject
            {
                Id = 166,
                Name = "Industrial Safety and Resource Management (GE)",
                Code = "IS5202"
            },
            new Subject
            {
                Id = 167,
                Name = "Financial Management (GE)",
                Code = "IS5303"
            },
            new Subject
            {
                Id = 168,
                Name = "Industrial Management (GE)",
                Code = "IS5304"
            },
            new Subject
            {
                Id = 169,
                Name = "Information Literacy and Scientific Communication Skills (GE)",
                Code = "IS5205"
            },
            new Subject
            {
                Id = 170,
                Name = "Mathematical Modelling ",
                Code = "IS6301"
            },
            new Subject
            {
                Id = 171,
                Name = "Introduction to Sociology (GE)",
                Code = "IS6202"
            },
            new Subject
            {
                Id = 172,
                Name = "Entrepreneurship and Project Management (GE)",
                Code = "IS6203"
            },
            new Subject
            {
                Id = 173,
                Name = "Management and Organizational Behavior (GE)",
                Code = "IS6304"
            },
            new Subject
            {
                Id = 174,
                Name = "Engineering Ethics (GE)",
                Code = "IS7101"
            },
            new Subject
            {
                Id = 175,
                Name = "English for the Professional World (GE)",
                Code = "IS8201"
            });


        }
    }
}






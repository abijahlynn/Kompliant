using Kompliant.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kompliant.Models
{
    public class KompliantContextInitializer : DropCreateDatabaseAlways<KompliantContext>
    {
        protected override void Seed(KompliantContext context)
        {
            var governingBodies = new List<GoverningBody>
                {
                    new GoverningBody() {Name = "CARF"},
                    new GoverningBody() {Name = "ODMHSA"}
                };
            governingBodies.ForEach(gb => context.GoverningBodies.Add(gb));
            context.SaveChanges();

            var standards = new List<Standard>
                {
                    new Standard() { StandardId = "1.H.2", Description = "Written procedures that promote the safety of persons served and personnel", GoverningBody = governingBodies[0]},
                    new Standard() { StandardId = "1.H.3", Description = "Education designed to reduce identified physical risks", GoverningBody = governingBodies[0] },
                    new Standard() { StandardId = "1.H.4", Description = "Personnel receive training in health and safety practices, identification of unsafe environmental factors, emergency and evacuation procedures, identification and reporting of critical incidents, reducing physical risks, and medication management, if appropriate", GoverningBody = governingBodies[0] },
                    new Standard() { StandardId = "1.H.5", Description = "Written emergency procedures", GoverningBody = governingBodies[0] },
                    new Standard() { StandardId = "1.H.7", Description = "Unannounced tests of all emergency procedures, including complete actual or simulated physical evacuation drills, tested on each shift at all locations", GoverningBody = governingBodies[0] }
                };
            standards.ForEach(s => context.Standards.Add(s));
            context.SaveChanges();

            var topics = new List<Topic>
                {
                    new Topic()
                    {
                        Name = "Leadership & Governance",
                        Description = "Concerns the governance of the organization",
                        Abbreviation = "GOV"
                    },
                    new Topic()
                    {
                        Name = "Legal Requirements",
                        Description = "Concerns the legal and regulatory requirements of the organization",
                        Abbreviation = "LEG"
                    },
                    new Topic()
                    {
                        Name = "Health & Safety",
                        Description = "Concerns the health and safety needs of the organization",
                        Abbreviation = "SAF"
                    },
                    new Topic()
                    {
                        Name = "Human Resources",
                        Description = "Concerns the management of human resource of the organization",
                        Abbreviation = "HUM"
                    },
                    new Topic()
                    {
                        Name = "Technology",
                        Description = "Concerns the management of technology assets of the organization",
                        Abbreviation = "TEC"
                    }
                };
            topics.ForEach(t => context.Topics.Add(t));
            context.SaveChanges();

            var requirements = new List<Requirement>
                {
                    new Requirement()
                    {
                        RequirementId = "HS-C-1",
                        Description =
                            "All active members are to receive Health & Safety Practice, unsafe environmental factors, emergency procedures, evacuation procedures, identification of critical incidents, reporting of critical incidents, medication management, reducing physical risk training",
                        Period = "Quarterly",
                        Topic = topics.Single(t => t.Abbreviation == "SAF"),
                        Standards =
                            new List<Standard>()
                            {
                                standards.Single(s => s.StandardId == "1.H.3"),
                                standards.Single(s => s.StandardId == "1.H.4"),
                                standards.Single(s => s.StandardId == "1.H.7")
                            }
                    },
                    new Requirement()
                    {
                        RequirementId = "HS-C-2",
                        Description =
                            "Graphic signs shall be posted and maintained at all facilities promoting the safety of persons served and personnel",
                        Period = "Initially",
                        Topic = topics.Single(t => t.Abbreviation == "SAF"),
                        Standards = new List<Standard>() {standards.Single(s => s.StandardId == "1.H.2")}
                    },
                    new Requirement()
                    {
                        RequirementId = "HS-M-1",
                        Description =
                            "A review is to be conducted to ensure all graphic signs are maintained and up to date",
                        Period = "Annually",
                        Topic = topics.Single(t => t.Abbreviation == "SAF"),
                        Standards = new List<Standard>() {standards.Single(s => s.StandardId == "1.H.2")}
                    },
                    new Requirement()
                    {
                        RequirementId = "HS-M-2",
                        Description =
                            "A QA review is to be conducted of the supplied documentation and attestation to training completion",
                        Period = "Annually",
                        Topic = topics.Single(t => t.Abbreviation == "SAF"),
                        Standards = new List<Standard>() {standards.Single(s => s.StandardId == "1.H.4")}
                    }
                };
            requirements.ForEach(r => context.Requirements.Add(r));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
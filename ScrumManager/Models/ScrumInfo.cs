using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models.Entities
{
    public class ScrumInfo
    {
        //Constructor unnecessary. All methods are static

        public static String UserStoryTip()
        {
            String userStoryToolTip = "A statement of a feature a user would like the product to have. Should contain a brief goal to be accomplished.";
            return userStoryToolTip;
        }

        public static String ProductBacklogTip()
        {
            String productBacklogTooltip = "the set of all user stories not yet completed. Stories may be added as project continues.";
            return productBacklogTooltip;
        }

        public static String ProductOwnerTip()
        {
            String productOwnerTooltip = "person who creates and orders the user stories in the product backlog.  Deals with costumers and upper management.";
            return productOwnerTooltip;
        }

        public static String ScrumMasterTip()
        {
            String scrumMasterToolTip = "Person who enforces Scrum practices and facilitates team meetings. actively identifies and fixes problems to progress";
            return scrumMasterToolTip;
        }

        public static String SprintPlanningTip()
        {
            String SprintPlanningToolTip = "Meeting that defines work plan for the sprint, Product backlog is prioritized, Tasks are broken down, and sprint goal established";
            return SprintPlanningToolTip;
        }

        public static String DailyMeetingTip()
        {
            String DailyMeetingToolTip = "A short meeting lasting around 15 minutes that all development team members participate in. Previous work, future work, and problems are explained during this time.";
            return DailyMeetingToolTip;
        }

        public static String SprintReviewTip()
        {
            String SprintReviewToolTip = "Meeting at the end of the sprint used to review the sprint’s progress. Identifies what went well and what did not and plans for the next sprint start";
            return SprintReviewToolTip;
        }

        public static String SprintRetrospectiveTip()
        {
            String SprintRetrospectiveToolTip = "meeting after sprint review used to identify potential problems of the last sprint involving people, processes, tools, or communications and how to better the problems";
            return SprintRetrospectiveToolTip;
        }

        public static String ScrumDesc()
        {
            String ScrumInformation = "Scrum is an agile framework designed to be used to manage complex product development. Scrum is a framework that involves several other processes and techniques. Scrum emphasizes product management and development so that these areas can be improved. The Scrum framework involves the use of teams and events to generate artifacts and improve progress on a product. Due to Scrum being a framework the actual implementation of Scrum can vary.";
            return ScrumInformation;
        }

        public static String ScrumTeamInfo()
        {
            String ScrumTeamInformation = "The Scrum team consists of several members including the product owner, Scrum master, and development team. Each of these members have specific roles that they play while also being self-organizing and cross functional to emphasize flexibility, creativity and productivity. The Scrum team’s goal is to develop products incrementally and iteratively which allows feedback to be given more often.";
            return ScrumTeamInformation;
        }

        public static String ProductOwnerInfo()
        {
            String ProductOwnerInformation = "The product owner is the person responsible for prioritizing the work the development team will be working on. They are responsible for maintaining the product backlog which includes ensuring the items in the backlog are clearly defined and understandable to the development team and making sure that the items are visible to the development team. The product owner is the one who gives the development team their requirements to work on and the development team should not follow requirements from any others without negotiating with the product owner first.";
            return ProductOwnerInformation;
        }

        public static String DevelopmentTeamInfo()
        {
            String DevelopmentTeamInformation = "The development team are the ones who do the actual work on the project. The team is responsible for organizing their own work to create synergy so that the team can work efficiently and effectively. The team makes the decision on how to turn backlog items into the actual product pieces. The team should be cross functional, and no titles are recognized by the Scrum framework. Scrum also does not recognize sub-teams in the development team and although it does recognize that individuals may have specialized skills, the responsibility falls on the entire team. The size of the development team can vary but it should be small enough to remain flexible while being large enough to be able to complete noticeable work during the sprint period. This team number should only count those who are actively contributing to completing tasks from the sprint backlog.";
            return DevelopmentTeamInformation;
        }

        public static String ScrumMasterInfo()
        {
            String ScrumMasterInformation = "The Scrum master ensures that everyone understands Scrum and are following its guidelines. The Scrum master interacts with people outside the Scrum team by explaining which actions are beneficial for the t team and which are not and helps change interactions so to the improve value of the interactions. The Scrum master helps the product owner by helping the team understand the need for clear and concise product backlog items, finding ways to improve product backlog management and having Scrum events when needed or requested. The Scrum master helps the development team by coaching the development team, removing problems to progress, and holding events when needed or requested. The Scrum master also helps the organization by leading or coaching the implementation of Scrum, helping employees understand Scrum, and working with other Scrum masters to increase the effectiveness of Scrum within the organization.";
            return ScrumMasterInformation;
        }

        public static String ScrumEventsInfo()
        {
            String ScrumEventsInformation = "Scrum utilizes events to create a sense of regularity and to reduce the number of meetings that need to take place outside of the scope of Scrum. These events are time based and once a sprint has begun its duration cannot be changed. The other events my end early once their goal is achieved. The events inside the sprint are formal opportunities to review and access things.";
            return ScrumEventsInformation;
        }

        public static String SprintInfo()
        {
            String SprintInformation = "A sprint is a container event that other Scrum events fall into. The sprint should be at max one month in time. These sprints are done to attempt to accomplish some smaller goal to the project that is a potentially sellable increment.";
            return SprintInformation;
        }

        public static String SprintPlanningInfo()
        {
            String SprintPlanningInformation = "The sprint planning meeting is a meeting performed at the start of the sprint. Its goal is to determine the goal of the sprint, what work needs to be done, and how that work will be done. The sprint goal is something that should be accomplishable by implementing items from the product backlog. The goal is meant to provide guidance to the development team as they work in the sprint. The work that needs to be completed during the sprint should be discussed between the product owner and the development team in terms of what needs to be done to reach the sprint goal, but it is the development team that decides how much work they can get done in the sprint. The way the chosen work gets done is up to the development team but typically it begins with designing the system. If the development team feels they have too little or too much work, they may renegotiate the selected backlog products with the product owner.";
            return SprintPlanningInformation;
        }

        public static String DailyMeetingInfo()
        {
            String DailyMeetingInformation = "The daily Scrum meeting is a meeting the development team has daily. It should be only about 15 minutes each day and is used to create a plan for the next 24 hrs. The daily meeting addresses what was done since the last daily meeting, what will be done by the next meeting, and if any problems were encountered and what the problems were if encountered. These daily meeting are used to monitor the progress the development team is making on the sprint backlog and how the progress is trending regarding reaching the sprint goal.";
            return DailyMeetingInformation;
        }

        public static String SprintReviewInfo()
        {
            String SprintReviewInformation = "The sprint review meeting is held at the end of the sprint to review the produced increment and to alter the product backlog as needed. During this meeting the Scrum team and stakeholders discuss the progress of the sprint and determine what should be done next sprint to optimize value. This meeting is not meant as a status update and as such is informal and is meant to show off the increment to get feedback.";
            return SprintReviewInformation;
        }

        public static String SprintRetrospectiveInfo()
        {
            String SprintRetrospectiveInformation = "The sprint retrospective meeting is meant as an internal review for the Scrum team. It takes place after the sprint review meeting but prior to the sprint planning meeting of the next sprint. This meeting is intended to identify potential improvements to the sprint process and highlight what went well, identify how working went last sprint regarding the people and processes and tools, and to plan for implementing the improvements to the Scrum team.";
            return SprintRetrospectiveInformation;
        }

        public static String ScrumArtifactsInfo()
        {
            String ScrumArtifactsInformation = "Scrum artifacts represent work that can be seen other members of the Scrum team. This includes the product backlog, sprint backlog, and the product increments. These artifacts need to be understood so that everyone working with them have the same idea.";
            return ScrumArtifactsInformation;
        }

        public static String ProductBacklogInfo()
        {
            String ProductBacklogInformation = "The product backlog is an ordered list of all possible things a product may need and acts as the single source of requirements for any changes that may need to be done. It is the responsibility of the product owner to prioritize things in the backlog and ensure that the backlog is available and clearly defined. This backlog may grow as new features and items are added. The backlog should be regularly refined so that it stays up to date and allow it to act as a way of viewing progress towards completion. The product owner may make changes to this backlog at his or her discretion.";
            return ProductBacklogInformation;
        }

        public static String SprintBacklogInfo()
        {
            String SprintBacklogInformation = "The sprint backlog is a subset of the items in the product backlog that has been selected by the development team to be used for the current sprint. The sprint backlog can be used to show what the development team plans to have accomplished in the next increment. This backlog makes the work remaining for the development team to reach what they decided needed to be done for the sprint goal visible. The sprint backlog should be detailed enough so that changes in progress can be understood in the daily scrum meetings. Only the development team may modify the sprint backlog as needed. This includes updating the estimated work remaining, adding new items to the backlog, or removing unnecessary items from the backlog.";
            return SprintBacklogInformation;
        }

        public static String IncrementsInfo()
        {
            String IncrementsInformation = "The increment is the sum of all the items in the product backlog that have been completed in the sprint and the value of the previous increments and this new increment should be complete as defined by the Scrum team.  This means that the new increment should be in a useable condition even if the product owner decides to not to release it.";
            return IncrementsInformation;
        }
    }
}

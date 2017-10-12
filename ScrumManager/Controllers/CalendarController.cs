using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumManager.Models;

namespace ScrumManager.Controllers
{
    public class CalendarController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Index()
        {
            string printCalendar = "";
            Person p1 = new Person("Ashley", "Joyner");
            Person p2 = new Person("Adam", "Nalbone");
            Person p3 = new Person("Ian", "Holley");
            Person p4 = new Person("John", "Hardy");
            Person p5 = new Person("Joshua", "Carmack");
            Event e1 = new Event();
            Event e2 = new Event();
            Event e3 = new Event();
            Event e4 = new Event();
            Event e5 = new Event();
            Event e6 = new Event();
            Event e7 = new Event();
            e1.ID = 1;
            e2.ID = 2;
            e3.ID = 3;
            e4.ID = 4;
            e5.ID = 5;
            e6.ID = 6;
            e7.ID = 7;
            e1.EventName = "Meeting\t";
            e2.EventName = "Sprint 1";
            e3.EventName = "Daily Scrum Mtg";
            e4.EventName = "Blockers";
            e5.EventName = "Daily Scrum Mtg";
            e6.EventName = "Sprint 2";
            e7.EventName = "Meeting\t";
            e1.EventType = "Stand up";
            e2.EventType = "Skype\t";
            e3.EventType = "Stand up";
            e4.EventType = "Skype\t";
            e5.EventType = "Stand up";
            e6.EventType = "Skype\t";
            e7.EventType = "Stand up";
            e1.EventLocation = "Bldg 2A Room 345";
            e2.EventLocation = "Bldg 1 Room 120\t";
            e3.EventLocation = "Bldg 2A Room 345";
            e4.EventLocation = "Bldg 2A Room 240";
            e5.EventLocation = "Bldg 1 Room 120\t";
            e6.EventLocation = "Bldg 2A Room 345";
            e7.EventLocation = "Bldg 2A Room 240";
            string start = "2017-10-12 11:00 AM";
            e1.StartTime = DateTime.ParseExact(start, "yyyy-MM-dd hh:mm tt", null);
            start = "2017-10-13 11:00 AM";
            e2.StartTime = DateTime.ParseExact(start, "yyyy-MM-dd hh:mm tt", null);
            start = "2017-11-30 02:00 PM";
            e3.StartTime = DateTime.ParseExact(start, "yyyy-MM-dd hh:mm tt", null);
            start = "2017-11-11 11:11 AM";
            e4.StartTime = DateTime.ParseExact(start, "yyyy-MM-dd hh:mm tt", null);
            start = "2017-11-24 01:00 PM";
            e5.StartTime = DateTime.ParseExact(start, "yyyy-MM-dd hh:mm tt", null);
            start = "2018-01-20 10:30 AM";
            e6.StartTime = DateTime.ParseExact(start, "yyyy-MM-dd hh:mm tt", null);
            start = "2017-11-24 10:00 AM";
            e7.StartTime = DateTime.ParseExact(start, "yyyy-MM-dd hh:mm tt", null);
            string end = "2017-10-12 11:30 AM";
            e1.EndTime = DateTime.ParseExact(end, "yyyy-MM-dd hh:mm tt", null);
            end = "2017-10-13 11:30 AM";
            e2.EndTime = DateTime.ParseExact(end, "yyyy-MM-dd hh:mm tt", null);
            end = "2017-11-30 03:00 PM";
            e3.EndTime = DateTime.ParseExact(end, "yyyy-MM-dd hh:mm tt", null);
            end = "2017-11-11 11:45 AM";
            e4.EndTime = DateTime.ParseExact(end, "yyyy-MM-dd hh:mm tt", null);
            end = "2017-11-24 01:30 PM";
            e5.EndTime = DateTime.ParseExact(end, "yyyy-MM-dd hh:mm tt", null);
            end = "2018-01-20 11:30 AM";
            e6.EndTime = DateTime.ParseExact(end, "yyyy-MM-dd hh:mm tt", null);
            end = "2017-11-24 10:30 AM";
            e7.EndTime = DateTime.ParseExact(end, "yyyy-MM-dd hh:mm tt", null);
            e1.Invitees.Add(p1);
            e1.Invitees.Add(p3);
            e1.Invitees.Add(p4);
            e2.Invitees.Add(p1);
            e2.Invitees.Add(p2);
            e2.Invitees.Add(p3);
            e2.Invitees.Add(p4);
            e2.Invitees.Add(p5);
            e3.Invitees.Add(p1);
            e3.Invitees.Add(p2);
            e3.Invitees.Add(p3);
            e3.Invitees.Add(p5);
            e4.Invitees.Add(p1);
            e4.Invitees.Add(p4);
            e5.Invitees.Add(p1);
            e5.Invitees.Add(p2);
            e5.Invitees.Add(p3);
            e5.Invitees.Add(p4);
            e5.Invitees.Add(p5);
            e6.Invitees.Add(p1);
            e6.Invitees.Add(p2);
            e6.Invitees.Add(p3);
            e6.Invitees.Add(p5);
            e7.Invitees.Add(p1);
            e7.Invitees.Add(p2);
            e7.Invitees.Add(p3);
            e7.Invitees.Add(p4);
            e7.Invitees.Add(p5);
            Calendar cal = new Calendar();
            cal.AddEvent(e1);
            cal.AddEvent(e2);
            cal.AddEvent(e3);
            cal.AddEvent(e4);
            cal.AddEvent(e5);
            cal.AddEvent(e6);
            cal.AddEvent(e7);
            cal.SortEvents();
            printCalendar = cal.DisplayEvents(p1);
            ViewData["Message"] = printCalendar;
            return View();
        }

    }
}
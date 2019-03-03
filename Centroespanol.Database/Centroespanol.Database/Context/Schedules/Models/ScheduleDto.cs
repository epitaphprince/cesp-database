using System;
using Centroespanol.Database.Context.Education.Models;

namespace Centroespanol.Database.Context.Schedules.Models
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public int StudentGroupId { get; set; }
        public StudentGroupDto StudentGroupDto { get; set; }
        
        public int ScheduleDayId { get; set; }
        public ScheduleDayDto ScheduleDay { get; set; }
        
        public DateTime StartLessonTime { get; set; }
        public DateTime EndLessonTime { get; set; }  
    }
}
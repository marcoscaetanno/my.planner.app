using System;
using System.Collections.Generic;
using my.planner.domain.DTOs;

namespace my.planner.services.Interfaces
{
    public interface IPlannerUseCase
    {
        EventDto GetOneEvent();
        List<EventDto> GetAllByPeriod(DateTime startDate, DateTime endDate);
        void CreateNewEvent(EventDto eventDto);
        void UpdateEvent(EventDto eventDto);
        void RemoveEvent(int idEvent);
    }
}
using System;
using System.Collections.Generic;
using my.planner.domain.DTOs;
using my.planner.services.Interfaces;

namespace my.planner.services.Implementations
{
    public class PlannerUseCase : IPlannerUseCase
    {
        public PlannerUseCase()
        {
        }

        public void CreateNewEvent(EventDto eventDto)
        {
            throw new NotImplementedException();
        }

        public List<EventDto> GetAllByPeriod(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public EventDto GetOneEvent()
        {
            throw new NotImplementedException();
        }

        public void RemoveEvent(int idEvent)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(EventDto eventDto)
        {
            throw new NotImplementedException();
        }
    }
}
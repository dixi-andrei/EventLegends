using AutoMapper;
using EventLegends.Models.DTOs;
using EventLegends.Models;

namespace EventLegends.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<EventParticipant,EventParticipantDto>();
            CreateMap<EventParticipantDto, EventParticipant>();

            CreateMap<EventParticipants, EventParticipantsDto>();
            CreateMap<EventParticipantsDto, EventParticipants>();

            CreateMap<Event, EventDto>();
            CreateMap<EventDto, Event>();

            CreateMap<EventTickets,EventTicketsDto>();
            CreateMap<EventTicketsDto, EventTickets>();

            CreateMap<Notification,NotificationDto>();
            CreateMap<NotificationDto, Notification>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();

            CreateMap<Organizer, OrganizerDto>();
            CreateMap<OrganizerDto, Organizer>();

            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();

            CreateMap<Ticket, TicketDto>();
            CreateMap<TicketDto, Ticket>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Venue, VenueDto>();
            CreateMap<VenueDto, Venue>();

        }
    }
}

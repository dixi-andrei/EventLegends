using EventLegends.Repositories.CategoryRepository;
using EventLegends.Repositories.EventCategoriesRepository;
using EventLegends.Repositories.EventParticipantRepository;
using EventLegends.Repositories.EventParticipantsRepository;
using EventLegends.Repositories.EventRepository;
using EventLegends.Repositories.EventSponsorRepository;
using EventLegends.Repositories.EventTicketsRepository;
using EventLegends.Repositories.NotificationRepository;
using EventLegends.Repositories.OrderRepository;
using EventLegends.Repositories.OrganizerRepository;
using EventLegends.Repositories.RatingRepository;
using EventLegends.Repositories.ReviewRepository;
using EventLegends.Repositories.SponsorRepository;
using EventLegends.Repositories.TagRepository;
using EventLegends.Repositories.TicketRepository;
using EventLegends.Repositories.UserRepository;
using EventLegends.Repositories.VenueRepository;
using EventLegends.Services.CategoryService;
using EventLegends.Services.EventCategoriesService;
using EventLegends.Services.EventParticipantService;
using EventLegends.Services.EventParticipantsService;
using EventLegends.Services.EventService;
using EventLegends.Services.EventSponsorService;
using EventLegends.Services.EventTicketsService;
using EventLegends.Services.NotificationService;
using EventLegends.Services.OrderService;
using EventLegends.Services.OrganizerService;
using EventLegends.Services.RatingService;
using EventLegends.Services.ReviewService;
using EventLegends.Services.SponsorService;
using EventLegends.Services.TagService;
using EventLegends.Services.TagsService;
using EventLegends.Services.TicketService;
using EventLegends.Services.UserService;
using EventLegends.Services.VenueService;

namespace EventLegends.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddCategoryRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            return services;
        }

        public static IServiceCollection AddCategoryServices(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            return services;
        }
        public static IServiceCollection AddEventRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEventRepository, EventRepository>();
            return services;
        }

        public static IServiceCollection AddEventServices(this IServiceCollection services)
        {
            services.AddTransient<IEventService, EventService>();
            return services;
        }

        public static IServiceCollection AddEventParticipantRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEventParticipantRepository, EventParticipantRepository>();
            return services;
        }

        public static IServiceCollection AddEventParticipantServices(this IServiceCollection services)
        {
            services.AddTransient<IEventParticipantService, EventParticipantService>();
            return services;
        }

        public static IServiceCollection AddEventParticipantsRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEventParticipantsRepository, EventParticipantsRepository>();
            return services;
        }

        public static IServiceCollection AddEventParticipantsServices(this IServiceCollection services)
        {
            services.AddTransient<IEventParticipantsService, EventParticipantsService>();
            return services;
        }

        public static IServiceCollection AddEventTicketsRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEventTicketsRepository, EventTicketsRepository>();
            return services;
        }

        public static IServiceCollection AddEventTicketsServices(this IServiceCollection services)
        {
            services.AddTransient<IEventTicketsService, EventTicketsService>();
            return services;
        }

        public static IServiceCollection AddEventCategoriesRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEventCategoriesRepository, EventCategoriesRepository>();
            return services;
        }

        public static IServiceCollection AddEventCategoriesServices(this IServiceCollection services)
        {
            services.AddTransient<IEventCategoriesService, EventCategoriesService>();
            return services;
        }

        public static IServiceCollection AddOrderRepositories(this IServiceCollection services)
        {
            services.AddTransient<IOrderRepository, OrderRepository>();
            return services;
        }

        public static IServiceCollection AddOrderServices(this IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            return services;
        }

        public static IServiceCollection AddOrganizerRepositories(this IServiceCollection services)
        {
            services.AddTransient<IOrganizerRepository, OrganizerRepository>();
            return services;
        }

        public static IServiceCollection AddOrganizerServices(this IServiceCollection services)
        {
            services.AddTransient<IOrganizerService, OrganizerService>();
            return services;
        }

        public static IServiceCollection AddNotificationRepositories(this IServiceCollection services)
        {
            services.AddTransient<INotificationRepository, NotificationRepository>();
            return services;
        }

        public static IServiceCollection AddNotificationServices(this IServiceCollection services)
        {
            services.AddTransient<INotificationService, NotificationService>();
            return services;
        }

        public static IServiceCollection AddReviewRepositories(this IServiceCollection services)
        {
            services.AddTransient<IReviewRepository, ReviewRepository>();
            return services;
        }

        public static IServiceCollection AddReviewServices(this IServiceCollection services)
        {
            services.AddTransient<IReviewService, ReviewService>();
            return services;
        }

        public static IServiceCollection AddTicketRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITicketRepository, TicketRepository>();
            return services;
        }

        public static IServiceCollection AddTicketServices(this IServiceCollection services)
        {
            services.AddTransient<ITicketService, TicketService>();
            return services;
        }
        
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
       

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();

            return services;
        }

        public static IServiceCollection AddVenueRepositories(this IServiceCollection services)
        {
            services.AddTransient<IVenueRepository, VenueRepository>();
            return services;
        }

        public static IServiceCollection AddVenueServices(this IServiceCollection services)
        {
            services.AddTransient<IVenueService, VenueService>();
            return services;
        }
        public static IServiceCollection AddSponsorRepositories(this IServiceCollection services)
        {
            services.AddTransient<ISponsorRepository, SponsorRepository>();
            return services;
        }

        public static IServiceCollection AddSponsorServices(this IServiceCollection services)
        {
            services.AddTransient<ISponsorService, SponsorService>();
            return services;
        }

        public static IServiceCollection AddEventSponsorRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEventSponsorRepository, EventSponsorRepository>();
            return services;
        }

        public static IServiceCollection AddEventSponsorServices(this IServiceCollection services)
        {
            services.AddTransient<IEventSponsorService, EventSponsorService>();
            return services;
        }

        public static IServiceCollection AddTagRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITagRepository, TagRepository>();
            return services;
        }

        public static IServiceCollection AddTagServices(this IServiceCollection services)
        {
            services.AddTransient<ITagService, TagService>();
            return services;
        }

        public static IServiceCollection AddRatingRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRatingRepository, RatingRepository>();
            return services;
        }

        public static IServiceCollection AddRatingServices(this IServiceCollection services)
        {
            services.AddTransient<IRatingService, RatingService>();
            return services;
        }
        public static IServiceCollection AddRatingRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRatingRepository, RatingRepository>();
            return services;
        }

        public static IServiceCollection AddRatingServices(this IServiceCollection services)
        {
            services.AddTransient<IRatingService, RatingService>();
            return services;
        }

    }
}

# EventLegends - ASP.NET Core Application

## Overview

EventLegends is an ASP.NET Core web application designed for managing and organizing events efficiently. Leveraging the power of C# and Entity Framework Core, this application provides a robust solution for handling various aspects of event management.

## Project Structure

The application consists of a data layer represented by the `AppDbContext` class, defining the database context and the corresponding models:

- **Models:**
  - **Category:** Represents event categories.
  - **Event:** Represents individual events, including details like reviews, participants, and tickets.
  - **EventCategories:** Represents the relationship between events and categories.
  - **EventParticipant:** Represents participants in an event, including tickets and orders.
  - **Notification:** Represents notifications for users.
  - **Order:** Represents orders for event tickets.
  - **Organizer:** Represents event organizers.
  - **Review:** Represents reviews for events.
  - **Ticket:** Represents event tickets.
  - **User:** Represents application users.
  - **Venue:** Represents event venues.
  - **EventTickets:** Represents the relationship between events and tickets.
  - **EventParticipants:** Represents the relationship between events and participants.
  - **Sponsor:** Represents event sponsors.
  - **EventSponsor:** Represents the relationship between events and sponsors.
  - **Tag:** Represents tags associated with events.
  - **Rating:** Represents user ratings for events.
  - **Media:** Represents media files associated with events.

## Database Relationships

The `AppDbContext` class defines the relationships between different entities, ensuring a well-structured and normalized database schema. Notable relationships include:

- Many-to-Many relationship between events and categories.
- One-to-Many relationships between organizers and events, events and reviews, events and participants, and more.

## Key Features

- **Event Management:**
  - Create, update, and delete events with detailed information.
  - Manage event categories and associated tags.
  - Track event participants and their orders.

- **User Interaction:**
  - Users can leave reviews for events.
  - Notifications keep users informed about relevant updates.
  - User profiles store information about event participation and notifications.

- **Venue Integration:**
  - Each event is associated with a venue, enhancing the user experience.

- **Sponsorship:**
  - Events can be sponsored, and sponsor details are managed within the application.

- **Media Gallery:**
  - Store and display media files related to events.

## Future Enhancements

This application lays the foundation for a comprehensive event management system. Future enhancements may include additional features for enhanced user engagement, reporting, and analytics.

Explore the world of EventLegends – where every event becomes legendary!

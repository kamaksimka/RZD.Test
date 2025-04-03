﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RZD.Database;

#nullable disable

namespace RZD.Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250403040719_SeedDate")]
    partial class SeedDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RZD.Database.Models.Car", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("ArePlacesForBusinessTravelBooking")
                        .HasColumnType("boolean")
                        .HasColumnName("are_places_for_business_travel_booking");

                    b.Property<DateTimeOffset>("ArrivalDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("arrival_date_time");

                    b.Property<string>("AvailabilityIndication")
                        .HasColumnType("text")
                        .HasColumnName("availability_indication");

                    b.Property<string>("CarNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("car_number");

                    b.Property<string>("CarPlaceType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("car_place_type");

                    b.Property<string>("CarSubType")
                        .HasColumnType("text")
                        .HasColumnName("car_sub_type");

                    b.Property<string>("CarType")
                        .HasColumnType("text")
                        .HasColumnName("car_type");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("DestinationStationCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("destination_station_code");

                    b.Property<string>("FreePlaces")
                        .HasColumnType("text")
                        .HasColumnName("free_places");

                    b.Property<bool>("HasDynamicPricing")
                        .HasColumnType("boolean")
                        .HasColumnName("has_dynamic_pricing");

                    b.Property<bool>("HasFssBenefit")
                        .HasColumnType("boolean")
                        .HasColumnName("has_fss_benefit");

                    b.Property<bool>("HasGenderCabins")
                        .HasColumnType("boolean")
                        .HasColumnName("has_gender_cabins");

                    b.Property<bool>("HasNonRefundableTariff")
                        .HasColumnType("boolean")
                        .HasColumnName("has_non_refundable_tariff");

                    b.Property<bool>("HasPlacesNearBabies")
                        .HasColumnType("boolean")
                        .HasColumnName("has_places_near_babies");

                    b.Property<bool>("HasPlacesNearPets")
                        .HasColumnType("boolean")
                        .HasColumnName("has_places_near_pets");

                    b.Property<bool>("IsAdditionalMealOptionPossible")
                        .HasColumnType("boolean")
                        .HasColumnName("is_additional_meal_option_possible");

                    b.Property<bool>("IsAdditionalPassengerAllowed")
                        .HasColumnType("boolean")
                        .HasColumnName("is_additional_passenger_allowed");

                    b.Property<bool>("IsBranded")
                        .HasColumnType("boolean")
                        .HasColumnName("is_branded");

                    b.Property<bool>("IsBuffet")
                        .HasColumnType("boolean")
                        .HasColumnName("is_buffet");

                    b.Property<bool>("IsCarTransportationCoach")
                        .HasColumnType("boolean")
                        .HasColumnName("is_car_transportation_coach");

                    b.Property<bool>("IsChildTariffTypeAllowed")
                        .HasColumnType("boolean")
                        .HasColumnName("is_child_tariff_type_allowed");

                    b.Property<bool>("IsForDisabledPersons")
                        .HasColumnType("boolean")
                        .HasColumnName("is_for_disabled_persons");

                    b.Property<bool>("IsMealOptionPossible")
                        .HasColumnType("boolean")
                        .HasColumnName("is_meal_option_possible");

                    b.Property<bool>("IsOnRequestMealOptionPossible")
                        .HasColumnType("boolean")
                        .HasColumnName("is_on_request_meal_option_possible");

                    b.Property<bool>("IsTwoStorey")
                        .HasColumnType("boolean")
                        .HasColumnName("is_two_storey");

                    b.Property<DateTimeOffset>("LocalArrivalDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("local_arrival_date_time");

                    b.Property<decimal>("MaxPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("max_price");

                    b.Property<DateTimeOffset>("MealSalesOpenedTill")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("meal_sales_opened_till");

                    b.Property<decimal>("MinPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("min_price");

                    b.Property<bool>("OnlyNonRefundableTariff")
                        .HasColumnType("boolean")
                        .HasColumnName("only_non_refundable_tariff");

                    b.Property<string>("PassengerSpecifyingRules")
                        .HasColumnType("text")
                        .HasColumnName("passenger_specifying_rules");

                    b.Property<int>("PlaceQuantity")
                        .HasColumnType("integer")
                        .HasColumnName("place_quantity");

                    b.Property<string>("PlaceReservationType")
                        .HasColumnType("text")
                        .HasColumnName("place_reservation_type");

                    b.Property<int>("PlacesWithConditionalRefundableTariffQuantity")
                        .HasColumnType("integer")
                        .HasColumnName("places_with_conditional_refundable_tariff_quantity");

                    b.Property<string>("ServiceClass")
                        .HasColumnType("text")
                        .HasColumnName("service_class");

                    b.Property<decimal>("ServiceCost")
                        .HasColumnType("numeric")
                        .HasColumnName("service_cost");

                    b.PrimitiveCollection<List<string>>("Services")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("services");

                    b.Property<long>("TrainId")
                        .HasColumnType("bigint")
                        .HasColumnName("train_id");

                    b.Property<string>("TripDirection")
                        .HasColumnType("text")
                        .HasColumnName("trip_direction");

                    b.HasKey("Id")
                        .HasName("pk_cars");

                    b.HasIndex("TrainId", "CarNumber", "CarPlaceType", "CarType", "CarSubType")
                        .IsUnique()
                        .HasDatabaseName("ix_cars_train_id_car_number_car_place_type_car_type_car_sub_ty");

                    b.ToTable("cars", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("ExpressCode")
                        .HasColumnType("text")
                        .HasColumnName("express_code");

                    b.Property<string>("ExpressCodes")
                        .HasColumnType("text")
                        .HasColumnName("express_codes");

                    b.Property<string>("ForeignCode")
                        .HasColumnType("text")
                        .HasColumnName("foreign_code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("node_id");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("region");

                    b.HasKey("Id")
                        .HasName("pk_cities");

                    b.HasIndex("NodeId")
                        .IsUnique()
                        .HasDatabaseName("ix_cities_node_id");

                    b.ToTable("cities", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.EntityHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("ChangedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("changed_at");

                    b.Property<long>("EntityId")
                        .HasColumnType("bigint")
                        .HasColumnName("entity_id");

                    b.Property<long>("EntityTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("entity_type_id");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("field_name");

                    b.Property<string>("OldFieldValue")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("old_field_value");

                    b.HasKey("Id")
                        .HasName("pk_entity_histories");

                    b.HasIndex("EntityTypeId")
                        .HasDatabaseName("ix_entity_histories_entity_type_id");

                    b.ToTable("entity_histories", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.EntityType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_entity_types");

                    b.ToTable("entity_types", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.Feedback", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("body");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_feedbacks");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_feedbacks_user_id");

                    b.ToTable("feedbacks", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.Route", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<DateTimeOffset>("DepartureDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("departure_date");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("destination");

                    b.Property<string>("DestinationName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("destination_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("origin");

                    b.Property<string>("OriginName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("origin_name");

                    b.Property<long>("TrainId")
                        .HasColumnType("bigint")
                        .HasColumnName("train_id");

                    b.Property<string>("TrainNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("train_number");

                    b.HasKey("Id")
                        .HasName("pk_routes");

                    b.HasIndex("TrainId")
                        .IsUnique()
                        .HasDatabaseName("ix_routes_train_id");

                    b.ToTable("routes", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.RouteStop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ActualMovement")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("actual_movement");

                    b.Property<DateTimeOffset>("ArrivalDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("arrival_date_time");

                    b.Property<string>("ArrivalTime")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("arrival_time");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<DateTimeOffset>("DepartureDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("departure_date_time");

                    b.Property<string>("DepartureTime")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("departure_time");

                    b.Property<DateTimeOffset>("LocalArrivalDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("local_arrival_date_time");

                    b.Property<string>("LocalArrivalTime")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("local_arrival_time");

                    b.Property<DateTimeOffset>("LocalDepartureDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("local_departure_date_time");

                    b.Property<string>("LocalDepartureTime")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("local_departure_time");

                    b.Property<long>("RouteId")
                        .HasColumnType("bigint")
                        .HasColumnName("route_id");

                    b.Property<string>("StationCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("station_code");

                    b.Property<int>("StopDuration")
                        .HasColumnType("integer")
                        .HasColumnName("stop_duration");

                    b.Property<int>("TimeZoneDifference")
                        .HasColumnType("integer")
                        .HasColumnName("time_zone_difference");

                    b.HasKey("Id")
                        .HasName("pk_route_stops");

                    b.HasIndex("RouteId")
                        .HasDatabaseName("ix_route_stops_route_id");

                    b.ToTable("route_stops", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.TrackedRoute", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("DestinationExpressCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("destination_express_code");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<string>("OriginExpressCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("origin_express_code");

                    b.HasKey("Id")
                        .HasName("pk_tracked_routes");

                    b.ToTable("tracked_routes", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.Train", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("ArrivalDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("arrival_date_time");

                    b.Property<int>("ArrivalStopTime")
                        .HasColumnType("integer")
                        .HasColumnName("arrival_stop_time");

                    b.PrimitiveCollection<List<string>>("CarServices")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("car_services");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<DateTimeOffset>("DepartureDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("departure_date_time");

                    b.Property<int>("DepartureStopTime")
                        .HasColumnType("integer")
                        .HasColumnName("departure_stop_time");

                    b.Property<string>("DestinationStationCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("destination_station_code");

                    b.Property<string>("DisplayTrainNumber")
                        .HasColumnType("text")
                        .HasColumnName("display_train_number");

                    b.Property<string>("FinalTrainStationCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("final_train_station_code");

                    b.Property<bool>("HasCarTransportationCoaches")
                        .HasColumnType("boolean")
                        .HasColumnName("has_car_transportation_coaches");

                    b.Property<bool>("HasDynamicPricingCars")
                        .HasColumnType("boolean")
                        .HasColumnName("has_dynamic_pricing_cars");

                    b.Property<bool>("HasTwoStoreyCars")
                        .HasColumnType("boolean")
                        .HasColumnName("has_two_storey_cars");

                    b.Property<string>("InitialTrainStationCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("initial_train_station_code");

                    b.Property<bool>("IsBranded")
                        .HasColumnType("boolean")
                        .HasColumnName("is_branded");

                    b.Property<bool>("IsFromSchedule")
                        .HasColumnType("boolean")
                        .HasColumnName("is_from_schedule");

                    b.Property<bool>("IsPlaceRangeAllowed")
                        .HasColumnType("boolean")
                        .HasColumnName("is_place_range_allowed");

                    b.Property<bool>("IsSaleForbidden")
                        .HasColumnType("boolean")
                        .HasColumnName("is_sale_forbidden");

                    b.Property<bool>("IsSuburban")
                        .HasColumnType("boolean")
                        .HasColumnName("is_suburban");

                    b.Property<bool>("IsTicketPrintRequiredForBoarding")
                        .HasColumnType("boolean")
                        .HasColumnName("is_ticket_print_required_for_boarding");

                    b.Property<bool>("IsTourPackagePossible")
                        .HasColumnType("boolean")
                        .HasColumnName("is_tour_package_possible");

                    b.Property<bool>("IsTrainRouteAllowed")
                        .HasColumnType("boolean")
                        .HasColumnName("is_train_route_allowed");

                    b.Property<bool>("IsWaitListAvailable")
                        .HasColumnType("boolean")
                        .HasColumnName("is_wait_list_available");

                    b.Property<DateTimeOffset>("LocalArrivalDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("local_arrival_date_time");

                    b.Property<DateTimeOffset>("LocalDepartureDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("local_departure_date_time");

                    b.Property<string>("OriginStationCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("origin_station_code");

                    b.Property<string>("TrainBrandCode")
                        .HasColumnType("text")
                        .HasColumnName("train_brand_code");

                    b.Property<string>("TrainDescription")
                        .HasColumnType("text")
                        .HasColumnName("train_description");

                    b.Property<string>("TrainNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("train_number");

                    b.Property<string>("TrainNumberToGetRoute")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("train_number_to_get_route");

                    b.Property<int>("TripDistance")
                        .HasColumnType("integer")
                        .HasColumnName("trip_distance");

                    b.Property<decimal>("TripDuration")
                        .HasColumnType("numeric")
                        .HasColumnName("trip_duration");

                    b.HasKey("Id")
                        .HasName("pk_trains");

                    b.HasIndex("TrainNumber", "OriginStationCode", "DestinationStationCode", "DepartureDateTime")
                        .IsUnique()
                        .HasDatabaseName("ix_trains_train_number_origin_station_code_destination_station");

                    b.ToTable("trains", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.TrainStation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("CityId")
                        .HasColumnType("bigint")
                        .HasColumnName("city_id");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("ExpressCode")
                        .HasColumnType("text")
                        .HasColumnName("express_code");

                    b.Property<string>("ForeignCode")
                        .HasColumnType("text")
                        .HasColumnName("foreign_code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("node_id");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("region");

                    b.HasKey("Id")
                        .HasName("pk_train_stations");

                    b.HasIndex("CityId")
                        .HasDatabaseName("ix_train_stations_city_id");

                    b.HasIndex("NodeId")
                        .IsUnique()
                        .HasDatabaseName("ix_train_stations_node_id");

                    b.ToTable("train_stations", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<DateTimeOffset?>("LastSingInDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_sing_in_date");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.UserRole", b =>
                {
                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("role_id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("RoleId", "UserId")
                        .HasName("pk_user_roles");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_user_roles_user_id");

                    b.ToTable("user_roles", (string)null);
                });

            modelBuilder.Entity("RZD.Database.Models.Car", b =>
                {
                    b.HasOne("RZD.Database.Models.Train", "Train")
                        .WithMany("Cars")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cars_trains_train_id");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("RZD.Database.Models.EntityHistory", b =>
                {
                    b.HasOne("RZD.Database.Models.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_entity_histories_entity_types_entity_type_id");

                    b.Navigation("EntityType");
                });

            modelBuilder.Entity("RZD.Database.Models.Feedback", b =>
                {
                    b.HasOne("RZD.Database.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_feedbacks_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RZD.Database.Models.Route", b =>
                {
                    b.HasOne("RZD.Database.Models.Train", "Train")
                        .WithOne("Route")
                        .HasForeignKey("RZD.Database.Models.Route", "TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_routes_trains_train_id");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("RZD.Database.Models.RouteStop", b =>
                {
                    b.HasOne("RZD.Database.Models.Route", "Route")
                        .WithMany("RouteStops")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_route_stops_routes_route_id");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("RZD.Database.Models.TrainStation", b =>
                {
                    b.HasOne("RZD.Database.Models.City", "City")
                        .WithMany("Stations")
                        .HasForeignKey("CityId")
                        .HasConstraintName("fk_train_stations_cities_city_id");

                    b.Navigation("City");
                });

            modelBuilder.Entity("RZD.Database.Models.UserRole", b =>
                {
                    b.HasOne("RZD.Database.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_roles_roles_role_id");

                    b.HasOne("RZD.Database.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_roles_users_user_id");
                });

            modelBuilder.Entity("RZD.Database.Models.City", b =>
                {
                    b.Navigation("Stations");
                });

            modelBuilder.Entity("RZD.Database.Models.Route", b =>
                {
                    b.Navigation("RouteStops");
                });

            modelBuilder.Entity("RZD.Database.Models.Train", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Route")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HutsApi.Models
{
    public class HutsContext : DbContext
    {
        public HutsContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Hut> Huts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuring fluent api
            modelBuilder.Entity<Hut>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Hut>()
                .Property(p => p.Name).IsRequired();

            #region Data Seed
            modelBuilder.Entity<Hut>().HasData(
                new Hut { Id = 1, Name = "Oriental", Address = "Aut. San Isidro", Longitude = -69.8247819, Latitude = 18.4895593 },
                new Hut { Id = 2, Name = "Alli", Address = "Aut. San Isidro", Longitude = -69.8241701, Latitude = 18.4892031 },
                new Hut { Id = 3, Name = "Aki", Address = "Aut. San Isidro", Longitude = -69.82277, Latitude = 18.487944 },
                new Hut { Id = 4, Name = "Cabañas Presidente", Address = "Aut. San Isidro", Longitude = -69.8226064, Latitude = 18.4901911 },
                new Hut { Id = 5, Name = "Extasis", Address = "Aut. San Isidro", Longitude = -69.8223988, Latitude = 18.4897408 },
                new Hut { Id = 6, Name = "Cariño", Address = "Aut. San Isidro", Longitude = -69.8221732, Latitude = 18.4897809 },
                new Hut { Id = 7, Name = "La compañia", Address = "Aut. San Isidro", Longitude = -69.8209564, Latitude = 18.4894887 },
                new Hut { Id = 8, Name = "yeah", Address = "Aut. San Isidro", Longitude = -69.8202862, Latitude = 18.4898938 },
                new Hut { Id = 9, Name = "Happy City", Address = "Aut. San Isidro", Longitude = -69.819985, Latitude = 18.4904198 },
                new Hut { Id = 10, Name = "El jardin", Address = "Aut. San Isidro", Longitude = -69.8195489, Latitude = 18.4896637 },
                new Hut { Id = 11, Name = "Universal", Address = "Aut. San Isidro", Longitude = -69.8185038, Latitude = 18.4903675 },
                new Hut { Id = 12, Name = "Obssetion", Address = "Aut. San Isidro", Longitude = -69.81748, Latitude = 18.4903327 },
                new Hut { Id = 13, Name = "Ta jevy", Address = "Aut. San Isidro", Longitude = -69.8175417, Latitude = 18.4905581 },
                new Hut { Id = 14, Name = "Miami", Address = "Aut. San Isidro", Longitude = -69.8226274, Latitude = 18.4911078 },
                new Hut { Id = 15, Name = "Scape", Address = "Aut. San Isidro", Longitude = -69.8229976, Latitude = 18.4906002 },
                new Hut { Id = 16, Name = "Cabañas del Caribe", Address = "Aut. San Isidro", Longitude = -69.8238441, Latitude = 18.490785 },
                new Hut { Id = 17, Name = "Nuevo mundo", Address = "Ave. Los Beisbolistas  Manoguayabo", Longitude = -69.9817793, Latitude = 18.4486967 },
                new Hut { Id = 18, Name = "Popular", Address = "Ave. Los Beisbolistas  Manoguayabo", Longitude = -69.9849883, Latitude = 18.4844427 },
                new Hut { Id = 19, Name = "Nuevo milenio", Address = "Ave. Los Beisbolistas  Manoguayabo", Longitude = -69.9845559, Latitude = 18.4840384 },
                new Hut { Id = 20, Name = "Manhattan", Address = "Ave. Los Beisbolistas  Manoguayabo", Longitude = -69.9797394, Latitude = 18.4838197 },
                new Hut { Id = 21, Name = "Ciudad de oro", Address = "Ave. Los Beisbolistas  Manoguayabo", Longitude = -69.9789202, Latitude = 18.4843454 },
                new Hut { Id = 22, Name = "Motel florida", Address = "Ave. Los Beisbolistas  Manoguayabo", Longitude = -69.9788404, Latitude = 18.4846382 },
                new Hut { Id = 23, Name = "Primavera", Address = "Ave. Los Beisbolistas  Manoguayabo", Longitude = -69.9821782, Latitude = 18.4841966 },
                new Hut { Id = 24, Name = "Ciudad corazón", Address = "Aut. Duarte KM 11 y 1/2", Longitude = -69.9917555, Latitude = 18.4982993 },
                new Hut { Id = 25, Name = "Villa campo", Address = "Aut. Duarte KM 11 y 1/2", Longitude = -69.992406, Latitude = 18.4985916 },
                new Hut { Id = 26, Name = "Bayamesa", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9894531, Latitude = 18.4244593 },
                new Hut { Id = 27, Name = "Mister", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9899155, Latitude = 18.4245182 },
                new Hut { Id = 28, Name = "Love", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.990071, Latitude = 18.4246644 },
                new Hut { Id = 29, Name = "Costa azul", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9903521, Latitude = 18.4251508 },
                new Hut { Id = 30, Name = "Si o No", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9911744, Latitude = 18.4264 },
                new Hut { Id = 31, Name = "Yes", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9925783, Latitude = 18.425093 },
                new Hut { Id = 32, Name = "Kiss", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9937288, Latitude = 18.4255589 },
                new Hut { Id = 33, Name = "La uni", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9937668, Latitude = 18.4249544 },
                new Hut { Id = 34, Name = "Tia Tania", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9922902, Latitude = 18.424263 },
                new Hut { Id = 35, Name = "Honey moon", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9916864, Latitude = 18.4241772 },
                new Hut { Id = 36, Name = "Chevere", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9908264, Latitude = 18.4234327 },
                new Hut { Id = 37, Name = "Okey", Address = "Aut. 30 de Mayo  KM 12", Longitude = -69.9904659, Latitude = 18.4237098 },
                new Hut { Id = 38, Name = "Queen", Address = "Calle Juan A Vicioso  Sto Dgo", Longitude = -69.9689244, Latitude = 18.4281617 },
                new Hut { Id = 39, Name = "Cabañas el Príncipe", Address = "Calle 32 Felix Evaristo Mejia", Longitude = -69.9099464, Latitude = 18.4945129 },
                new Hut { Id = 40, Name = "Cabañas La Playa", Address = "Ave. Pedro Livio Cedeño", Longitude = -69.9138853, Latitude = 18.4961435 },
                new Hut { Id = 41, Name = "La Oficina", Address = "Aut. San Isidro", Longitude = -69.8215424, Latitude = 18.4901968 },
                new Hut { Id = 42, Name = "Hotel Fiesta", Address = "Calle Americo Lugo", Longitude = -69.9158929, Latitude = 18.4902167 },
                new Hut { Id = 43, Name = "Hotel cabañas Isla de Oro", Address = "Calle Mauricio Baez", Longitude = -69.9150969, Latitude = 18.4881737 },
                new Hut { Id = 44, Name = "Hotel cabañas Sol de Verano", Address = "Ave. Nicolas de Ovando", Longitude = -69.9102711, Latitude = 18.5001781 },
                new Hut { Id = 45, Name = "Hotel cabañas Lincoln", Address = "Ave. Nicolas de Ovando", Longitude = -69.9116509, Latitude = 18.5001567 },
                new Hut { Id = 46, Name = "Cabaña Hotel Latino", Address = "Calle 28 Anibal de Espinosa", Longitude = -69.9096066, Latitude = 18.49636 },
                new Hut { Id = 47, Name = "Cabañas Hotel 8", Address = "Calle 28 Anibal de Espinosa", Longitude = -69.9172533, Latitude = 18.4897322 },
                new Hut { Id = 48, Name = "Cabañas el mundo del Amor", Address = "Ensanche la Fe", Longitude = -69.9219331, Latitude = 18.4972315 },
                new Hut { Id = 49, Name = "Cabañas Hotel Internacional", Address = "Calle San Juan de la Maguana", Longitude = -69.9128229, Latitude = 18.5017274 },
                new Hut { Id = 50, Name = "Cabañas el Bonche", Address = "Av. Hermanas Mirabal  Villa Mella", Longitude = -69.915572, Latitude = 18.5274488 },
                new Hut { Id = 51, Name = "Cabañas Monte Bonito", Address = "Calle Ramon Matias Mella  Villa Mella", Longitude = -69.9002959, Latitude = 18.5506129 },
                new Hut { Id = 52, Name = "Cabañas hotel Super", Address = "Ave. Charles de Gaulle  Villa Mella", Longitude = -69.8977764, Latitude = 18.5452266 },
                new Hut { Id = 53, Name = "Cabañas Horny", Address = "Ave. Charles de Gaulle  Villa Mella", Longitude = -69.8900657, Latitude = 18.5472231 },
                new Hut { Id = 54, Name = "Cabañas Hoy", Address = "Ave. Charles de Gaulle  Sabana Perdida", Longitude = -69.8551766, Latitude = 18.5409178 },
                new Hut { Id = 55, Name = "Cabañas Preciosa", Address = "Ave. Charles de Gaulle  Sabana Perdida", Longitude = -69.8562209, Latitude = 18.5419523 },
                new Hut { Id = 56, Name = "Cabañas la Paz", Address = "Ave. Charles de Gaulle  Zona Horiental", Longitude = -69.8477746, Latitude = 18.5352771 },
                new Hut { Id = 57, Name = "Cabañas Miramar", Address = "Marginal de las Americas", Longitude = -69.8206859, Latitude = 18.4670822 },
                new Hut { Id = 58, Name = "Cabañas Son", Address = "Marginal de las Americas", Longitude = -69.7933959, Latitude = 18.4666969 },
                new Hut { Id = 59, Name = "Cabañas Centrun", Address = "Ave. 27 de Febrero  Santo Domingo", Longitude = -69.9639619, Latitude = 18.4508808 },
                new Hut { Id = 60, Name = "Cabañas Ahora", Address = "Ave. Isabel Aguiar  Sto Dgo.", Longitude = -69.973697, Latitude = 18.468564 },
                new Hut { Id = 61, Name = "Cabañas Hotel Roma", Address = "Ave. Isabel Aguiar  Santo Domingo", Longitude = -69.972385, Latitude = 18.4714167 },
                new Hut { Id = 62, Name = "Hotel Cabañas Mi Cam Cam", Address = "Ave. Isabel Aguiar  Santo Domingo", Longitude = -69.9715804, Latitude = 18.4733415 },
                new Hut { Id = 63, Name = "Cabañas Turistica Eclipse", Address = " Aut. Duarte  Santiago De Los Caballeros", Longitude = -70.6478927, Latitude = 19.4247288 },
                new Hut { Id = 64, Name = "Bora Bora Aparta Hotel", Address = "Aut. Duarte  Santiago De Los Caballeros", Longitude = -70.6487867, Latitude = 19.4202428 },
                new Hut { Id = 65, Name = "Cabañas Venus", Address = "Santiago De Los Caballeros", Longitude = -70.6467146, Latitude = 19.415979 },
                new Hut { Id = 66, Name = "Helios Aparta Hotel", Address = "Santiago De Los Caballeros", Longitude = -70.6483531, Latitude = 19.4200141 },
                new Hut { Id = 67, Name = "Cabañas Turisticas Ethics", Address = "Santiago De Los Caballeros", Longitude = -70.6398897, Latitude = 19.4114847 },
                new Hut { Id = 68, Name = "Moteles El Arco", Address = "Carretera Las Palomas  Santiago De Los Caballeros", Longitude = -70.6487839, Latitude = 19.4261352 },
                new Hut { Id = 69, Name = "Horus Aparta Hotel", Address = "Carretera Sabaneta  Las Palomas ", Longitude = -70.6513704, Latitude = 19.4261352 },
                new Hut { Id = 70, Name = "Cabañas Villas del Sol", Address = "Santiago De Los Caballeros", Longitude = -70.667988, Latitude = 19.4438366 },
                new Hut { Id = 71, Name = "Cabañas Imperial", Address = " Carretera Las Palomas  Santiago ", Longitude = -70.6512062, Latitude = 19.4255671 },
                new Hut { Id = 72, Name = "Moteles el Palmar", Address = "Santiago De Los Caballeros", Longitude = -70.6512666, Latitude = 19.4197816 },
                new Hut { Id = 73, Name = "Moteles Venus ", Address = " Santiago De Los Caballeros", Longitude = -70.6670076, Latitude = 19.4451653 },
                new Hut { Id = 74, Name = "Cabañas aparta Hotel Pegasus", Address = "Santiago De Los Caballeros", Longitude = -70.6653328, Latitude = 19.450054 },
                new Hut { Id = 75, Name = "Cabañas Turísticas Afrodita", Address = "Santiago De Los Caballeros", Longitude = -70.6656085, Latitude = 19.4497652 },
                new Hut { Id = 76, Name = "Cabañas Elysium", Address = "Santiago De Los Caballeros", Longitude = -70.7415054, Latitude = 19.500501 },
                new Hut { Id = 77, Name = "Hotel Cabañas Reunion", Address = "Aut. Las Americas ", Longitude = -69.8672233, Latitude = 18.4855704 },
                new Hut { Id = 78, Name = "Cabañas Hotel La Cita", Address = "Ave. San Vincente de Paul", Longitude = -69.8744881, Latitude = 18.5103345 },
                new Hut { Id = 79, Name = "Cabañas Diamante Azul", Address = "Ave. San Vicente de Paul", Longitude = -69.8513963, Latitude = 18.4943937 },
                new Hut { Id = 80, Name = "Cabañas Hotel El Crucero", Address = "Ave. San Vicente de Paul", Longitude = -69.8515271, Latitude = 18.4962871 },
                new Hut { Id = 81, Name = "Cabañas aparta hotel Galaxy", Address = "La Vega", Longitude = -70.5252284, Latitude = 19.2417488 },
                new Hut { Id = 82, Name = "Cabañas Turísticas La Vega Real", Address = "Aut. Duarte  La Vega", Longitude = -70.5628029, Latitude = 19.2539646 },
                new Hut { Id = 83, Name = "Cabañas Paraiso", Address = "Aut. Duarte  La Vega", Longitude = -70.5701669, Latitude = 19.2750618 },
                new Hut { Id = 84, Name = "Cabañas Jupiter", Address = "Aut. Duarte  La Vega", Longitude = -70.5866117, Latitude = 19.3176179 },
                new Hut { Id = 85, Name = "Cabañas Villa Bella", Address = "La Vega", Longitude = -70.6035905, Latitude = 19.3636477 },
                new Hut { Id = 86, Name = "Cabañas Turísticas Atlas", Address = "Aut. Duarte  La Vega", Longitude = -70.4969607, Latitude = 19.218303 },
                new Hut { Id = 87, Name = "Cabañas las Palmas", Address = "Aut. Duarte  Bonao", Longitude = -70.387952, Latitude = 18.932263 },
                new Hut { Id = 88, Name = "Cabañas La Fuente del Placer", Address = "Aut. Duarte  Bonao", Longitude = -70.3863643, Latitude = 18.9321255 },
                new Hut { Id = 89, Name = "Cabañas Heaven", Address = "Aut. Duarte  Piedra Blanca", Longitude = -70.3428304, Latitude = 18.8575911 },
                new Hut { Id = 90, Name = "Cabañas aparta hotel Ibiza", Address = "Aut. Joaquin Balaguer  Santiago", Longitude = -70.7464482, Latitude = 19.5022744 },
                new Hut { Id = 91, Name = "Cabañas Turísticas Blue Castle", Address = "Santiago De Los Caballeros", Longitude = -70.7461077, Latitude = 19.5036901 },
                new Hut { Id = 92, Name = "Cabañas Zeus", Address = "Santiago De Los Caballeros", Longitude = -70.6399116, Latitude = 19.4163799 },
                new Hut { Id = 93, Name = "Cabañas Poseidon", Address = "Santiago De Los Caballeros", Longitude = -70.7458783, Latitude = 19.5050164 },
                new Hut { Id = 94, Name = "Cabañas Venus VIP", Address = "Santiago De Los Caballeros", Longitude = -70.7456944, Latitude = 19.5067892 },
                new Hut { Id = 95, Name = "Cabañas Mirage", Address = "Circunvalacion Norte  Villa Gonzalez  Santiago ", Longitude = -70.7626404, Latitude = 19.5195331 },
                new Hut { Id = 96, Name = "Cabañas Copa Caribe", Address = "Higuey La Otra Banda  km 1.5", Longitude = -68.6952653, Latitude = 18.6442994 },
                new Hut { Id = 97, Name = "Hotel Restaurant Londres", Address = "Ave. San Martín No.198  Ens. La Fé", Longitude = -69.91584520787, Latitude = 18.4845778662322 },
                new Hut { Id = 98, Name = "Bonao Inn", Address = "Ave. de las Hortensias", Longitude = -70.4021229967474, Latitude = 18.9522115338851 },
                new Hut { Id = 99, Name = "Hermes Aparta Hotel", Address = "Ave. de las Hortensias", Longitude = -70.3977107629179, Latitude = 18.9442165985579 },
                new Hut { Id = 100, Name = "Hotel José Contreras", Address = "Av. Jose Contreras", Longitude = -69.923944, Latitude = 18.460312 },
                new Hut { Id = 101, Name = "Malibu", Address = "Aut. San Isidro", Longitude = -69.8236965760588, Latitude = 18.4896759462002 },
                new Hut { Id = 102, Name = "Aparta Hotel Los Pinos", Address = "La Vega", Longitude = -70.4948201403021, Latitude = 19.2030047567138 },
                new Hut { Id = 103, Name = "View Aparta Hotel", Address = "Av. Presidente Antonio Guzman F.", Longitude = -70.7249385863542, Latitude = 19.4406008176606 },
                new Hut { Id = 104, Name = "Cabañas Cupido", Address = "Aut. 6 de Noviembre", Longitude = -70.13754, Latitude = 18.40457 },
                new Hut { Id = 105, Name = "Hotel Maison Gautreaux", Address = "", Longitude = -69.8959422111511, Latitude = 18.4642247363812 },
                new Hut { Id = 106, Name = "Residencia Hotel Madrugada", Address = "", Longitude = -69.56278, Latitude = 19.306 },
                new Hut { Id = 107, Name = "Hotel Discovery", Address = "Calle Arzobispo Nouel #402", Longitude = -69.891122, Latitude = 18.470904 },
                new Hut { Id = 108, Name = "Hotel Duque de Wellington", Address = "Ave. Independencia No. 304  Gazcue", Longitude = -69.89688, Latitude = 18.465494 },
                new Hut { Id = 109, Name = " Hotel Riparbella", Address = "Calle Danae #35  Gazcue", Longitude = -69.89764, Latitude = 18.468427 },
                new Hut { Id = 110, Name = "Hotel Bella Vista", Address = "Av Doctor Fernando Arturo Defilló # 43", Longitude = -69.947285, Latitude = 18.457052 },
                new Hut { Id = 111, Name = " Hotel Royal Palace", Address = "Abraham Lincoln #116", Longitude = -69.924855, Latitude = 18.455647 },
                new Hut { Id = 112, Name = "Hotel Aladino", Address = "Calle Dr. Heriberto Pieter No.34  Ensanche Naco", Longitude = -69.927802, Latitude = 18.481586 },
                new Hut { Id = 113, Name = "Hotel-Residence Venezia", Address = "Av. Independencia #45  Gazcue", Longitude = -69.894406, Latitude = 18.468387 },
                new Hut { Id = 114, Name = "Hotel La Danae", Address = "Calle La Danae No. 18  Gazcue", Longitude = -69.897242, Latitude = 18.467873 },
                new Hut { Id = 115, Name = "Hotel Conde de Peñalba", Address = "Calle Arzobispo Meriño #111", Longitude = -69.884463, Latitude = 18.47377 },
                new Hut { Id = 116, Name = " Boutique Hotel Palacio", Address = "Calle Duarte 106  Ciudad Colonial", Longitude = -69.886276, Latitude = 18.473739 },
                new Hut { Id = 117, Name = "Hotel Mango", Address = "Arismendy Valenzuela 2", Longitude = -69.607816, Latitude = 18.451426 },
                new Hut { Id = 118, Name = "Hotel Zapata", Address = "Calle Abraham Nuñez #27", Longitude = -69.608624, Latitude = 18.447242 },
                new Hut { Id = 119, Name = "Hotel Neptuno", Address = "Calle Duarte #17", Longitude = -69.599419, Latitude = 18.448514 },
                new Hut { Id = 120, Name = "Apart-Hotel Parco Del Caribe", Address = "Calle San Rafael  # 18", Longitude = -69.613347, Latitude = 18.448331 },
                new Hut { Id = 121, Name = "Hotel El Gaucho", Address = "Calle 20 de Diciembre #5", Longitude = -69.60677, Latitude = 18.44952 },
                new Hut { Id = 122, Name = "Hotel Casa Coco", Address = "Calle Dominguez  #8", Longitude = -69.608275, Latitude = 18.448058 },
                new Hut { Id = 123, Name = "Hotel el Rey", Address = "Calle Don Antonio Guzman No. 3", Longitude = -70.5304103717207, Latitude = 19.2308799288657 },
                new Hut { Id = 124, Name = "Hotel Jacaranda", Address = "Aut. Duarte", Longitude = -70.4135841, Latitude = 18.9676003 },
                new Hut { Id = 125, Name = "Carey House Hotel", Address = "Cesar Nicolas Penson Gazcue", Longitude = -69.8976920172572, Latitude = 18.4724516297734 },
                new Hut { Id = 126, Name = "Monaco Cottage", Address = "Las Terrenas", Longitude = -69.5557386841201, Latitude = 19.3069393953552 },
                new Hut { Id = 127, Name = "Cabañas Villa España", Address = "Los Tres Ojos", Longitude = -69.846737, Latitude = 18.482634 },
                new Hut { Id = 128, Name = "Hotel Cabañas Presidente", Address = "Ave Juan Pablo Duarte", Longitude = -69.9004600569605, Latitude = 18.494551938272 },
                new Hut { Id = 129, Name = "Casa de huespedes Mildania", Address = "Calle Santa Barbara", Longitude = -69.332436, Latitude = 19.203859 },
                new Hut { Id = 130, Name = "DOCIA BLACKPAKERS", Address = "Calle Duarte", Longitude = -69.333596, Latitude = 19.204856 },
                new Hut { Id = 131, Name = "Hotel Leidy", Address = "C/ Francisco del Rosario Sanchez", Longitude = -69.339261, Latitude = 19.203838 },
                new Hut { Id = 132, Name = "Hotel Cotubanama", Address = "Ave Circunvalacion", Longitude = -69.338134, Latitude = 19.203815 },
                new Hut { Id = 133, Name = " Hotel Escuela Macorix", Address = "Malecon San Pedro", Longitude = -69.309974, Latitude = 18.440551 },
                new Hut { Id = 134, Name = "Apartamentos OASIS", Address = "Guayacanes", Longitude = -69.458357, Latitude = 18.418574 },
                new Hut { Id = 135, Name = "Hotel Fior Di Loto", Address = "Juan Dolio", Longitude = -69.416025, Latitude = 18.426688 },
                new Hut { Id = 136, Name = "Pensión Lucirooms", Address = "Calle Central 79", Longitude = -69.469696, Latitude = 18.416132 },
                new Hut { Id = 137, Name = "Hotel Olimpo", Address = "Av. Padre Abreu Esq. Pedro A. Lluberes", Longitude = -68.970692, Latitude = 18.432724 },
                new Hut { Id = 138, Name = "Hotel Vecchia Caserma", Address = "Carretera La Romana - Bayahibe Km 13", Longitude = -68.867803, Latitude = 18.43855 },
                new Hut { Id = 139, Name = " K&C Gran Hotel", Address = "Carretera Higüey - Yuma Km. 1", Longitude = -68.716961, Latitude = 18.592864 },
                new Hut { Id = 140, Name = "Mi Tesoro", Address = "Carretera Higuey-Yuma", Longitude = -68.687401, Latitude = 18.431927 },
                new Hut { Id = 141, Name = "Hotel Bayahibe", Address = "Calle Principal", Longitude = -68.839256, Latitude = 18.369829 },
                new Hut { Id = 142, Name = " Guesthouse Las Piedras", Address = "Ave EE UU  C/Guarionex 3", Longitude = -68.454255, Latitude = 18.687815 },
                new Hut { Id = 143, Name = "Aparta Hotel Veron", Address = "Carretera Punta Cana a 300m", Longitude = -68.483043, Latitude = 18.604693 },
                new Hut { Id = 144, Name = "Hotel Yonu", Address = "Carretera de Veron-Punta Cana km 31", Longitude = -68.438194, Latitude = 18.597025 },
                new Hut { Id = 145, Name = "Hotel Restaurant El Bosque", Address = "Carretera Higuey Punta Cana Km 31", Longitude = -68.444218, Latitude = 18.596541 },
                new Hut { Id = 146, Name = "Apartamentos Villa Elena", Address = "Residencial Villas Bávaro  Avenida del Bosque", Longitude = -68.412332, Latitude = 18.66775 },
                new Hut { Id = 147, Name = "Hotel Flamboyan", Address = "Avenida Italia", Longitude = -68.440277, Latitude = 18.692194 },
                new Hut { Id = 148, Name = "Bavaro Hostel", Address = "Los Corales", Longitude = -68.4165, Latitude = 18.684122 },
                new Hut { Id = 149, Name = "Hotel El Viajante", Address = "Carretera Veron Km 36", Longitude = -68.453391, Latitude = 18.594697 },
                new Hut { Id = 150, Name = "Hostel Punta Cana", Address = "Principe de Los Corales  14", Longitude = -68.449513, Latitude = 18.700221 },
                new Hut { Id = 151, Name = "Apartamento Bavaro Punta Cana El Dorado", Address = "Av. Alemania", Longitude = -68.413034, Latitude = 18.682006 },
                new Hut { Id = 152, Name = " Hotel Plaza Coral", Address = "Carretera Verón Punta Cana Km 48", Longitude = -68.398071, Latitude = 18.58324 },
                new Hut { Id = 153, Name = "Hotel Casa Robinson", Address = "Las Terrenas", Longitude = -69.535893, Latitude = 19.321744 },
                new Hut { Id = 154, Name = "Cabañas Bernard", Address = "Boca de Mao", Longitude = -71.033572, Latitude = 19.586744 },
                new Hut { Id = 155, Name = "Cabañas Monte Bello", Address = "Boca de Mao", Longitude = -71.028559, Latitude = 19.585522 },
                new Hut { Id = 156, Name = "El Rancho Lembert", Address = "Polo  Barahona", Longitude = -71.2737418379211, Latitude = 18.1154092209693 },
                new Hut { Id = 157, Name = "Hotel alegria", Address = "San Juan ", Longitude = -71.36719, Latitude = 18.86471 },
                new Hut { Id = 158, Name = "Hotel El Encuentro", Address = "", Longitude = -70.01069, Latitude = 18.521148 },
                new Hut { Id = 159, Name = "Hotel Noche de Travesuras", Address = "ave. Albert Thomas # 264", Longitude = -69.8966804891824, Latitude = 18.5043225825358 },
                new Hut { Id = 160, Name = "Cabañas Tentacion", Address = "", Longitude = -70.285514, Latitude = 18.256879 },
                new Hut { Id = 161, Name = "Hotel Cima", Address = "", Longitude = -69.9759280309081, Latitude = 18.4625115721558 },
                new Hut { Id = 162, Name = " Hotel Casa Marina Beach Resort", Address = "Dr A Martínez 1  Sosua", Longitude = -70.51653, Latitude = 19.76635 },
                new Hut { Id = 163, Name = "Aparta Hotel Sensación", Address = "Carr Puerto Plata - Navarrete", Longitude = -70.730485, Latitude = 19.812034 },
                new Hut { Id = 164, Name = "Olympus Cabañas Turísticas", Address = "Car Limonal Abajo Km 7 1/2", Longitude = -70.64688, Latitude = 19.417732 },
                new Hut { Id = 165, Name = "Cabañas Turísticas Tu y Yo", Address = "Car Romana - S Pedro Km 6", Longitude = -69.041272, Latitude = 18.444291 },
                new Hut { Id = 166, Name = "Cabañas Turísticas Las Nubes", Address = " R Cáceres 1  Coroso", Longitude = -70.5324, Latitude = 19.386802 },
                new Hut { Id = 167, Name = "Casa de Campo Hotel", Address = "Car La Romana - Higuey ", Longitude = -68.9469289, Latitude = 18.4241362 },
                new Hut { Id = 168, Name = "Anubys Cabañas Turísticas", Address = "Car San Fco - Tenares 12", Longitude = -70.278323, Latitude = 19.325865 },
                new Hut { Id = 169, Name = "Bellamar Hotel Y Restaurant", Address = "Aut 30 de Mayo 12", Longitude = -69.9271, Latitude = 18.4439 },
                new Hut { Id = 170, Name = "Cabaña Villa Ensueño", Address = "Car Padre Billini 1", Longitude = -70.501231, Latitude = 18.549613 },
                new Hut { Id = 171, Name = "Cabañas Cine", Address = "Aut 6 de Noviembre 1", Longitude = -70.144323, Latitude = 18.397106 },
                new Hut { Id = 172, Name = "Cabañas Cine SD", Address = "Aut 6 de Noviembre 1  San Cristóbal", Longitude = -69.9658, Latitude = 18.44318 },
                new Hut { Id = 173, Name = "Cabañas Cristal", Address = "Car Mella 1", Longitude = -68.726164, Latitude = 18.620285 },
                new Hut { Id = 174, Name = "Cabañas De Amor", Address = "Av 6 de Noviembre 10", Longitude = -70.099157, Latitude = 18.430342 },
                new Hut { Id = 175, Name = "Cabañas Eros", Address = "Car Guiza-Las Guaranas 1", Longitude = -70.22049, Latitude = 19.205321 },
                new Hut { Id = 176, Name = "Cabañas La Curva del Amor", Address = " Car Uvero Alto 1  Punta Cana ", Longitude = -68.585114, Latitude = 18.806797 },
                new Hut { Id = 177, Name = "Cabañas California", Address = "", Longitude = -69.992958, Latitude = 18.424428 },
                new Hut { Id = 178, Name = "Cabañas Good", Address = "Av K Adenauer 11  Santo Domingo", Longitude = -69.900239, Latitude = 18.545435 },
                new Hut { Id = 179, Name = "Cabañas Holy Day", Address = "Carr Duarte 1  Cotui", Longitude = -70.69999, Latitude = 19.46666 },
                new Hut { Id = 180, Name = "Cabañas La Macorisana", Address = "San Francisco de Macorís", Longitude = -70.2818, Latitude = 19.3076 },
                new Hut { Id = 181, Name = "Cabañas Turisticas Sueños", Address = "Carr Duarte Km 3  Santiago", Longitude = -70.654578, Latitude = 19.428108 },
                new Hut { Id = 182, Name = "Cabañas Villa Hermosa", Address = " Aut Stgo Navarrete  Santiago", Longitude = -70.725161, Latitude = 19.491103 },
                new Hut { Id = 183, Name = "Cabañas Vista Bávaro", Address = "Av E Unidos 5", Longitude = -68.431177, Latitude = 18.666169 },
                new Hut { Id = 184, Name = "Cañabas Perla", Address = "Carr Guáranas Km 13 1/2", Longitude = -70.2216, Latitude = 19.2618 },
                new Hut { Id = 185, Name = "Cabañas Rebu", Address = "", Longitude = -70.21947, Latitude = 19.26178 },
                new Hut { Id = 186, Name = "Carolina High Aparta Hotel", Address = "Carr San Fco-Tenares 12", Longitude = -70.278486, Latitude = 19.325167 },
                new Hut { Id = 187, Name = "Casa Dorada", Address = "Av Pdte A G Fernández 1", Longitude = -70.271215, Latitude = 19.287307 },
                new Hut { Id = 188, Name = "Centro Turístico Girasoles", Address = "Carr G las Guáranas 1", Longitude = -70.058184, Latitude = 19.214804 },
                new Hut { Id = 189, Name = "De La Montaña Cabañas Turísticas", Address = "Carr F Basilis 20", Longitude = -70.654643, Latitude = 19.100668 },
                new Hut { Id = 190, Name = "Gran Bahamas Hotel & Cabañas", Address = "Av Las Américas Km 10", Longitude = -69.821235, Latitude = 18.466047 },
                new Hut { Id = 191, Name = "Hotel Cabaña San Roque", Address = "J I Reyes 65", Longitude = -71.077546, Latitude = 19.55793 },
                new Hut { Id = 192, Name = "Cabañas Las Colinas Del Placer", Address = "Carr Palenque 38", Longitude = -70.124531, Latitude = 18.288038 },
                new Hut { Id = 193, Name = "Cabañas Madrid", Address = "Aut 30 de Mayo 12", Longitude = -69.9899, Latitude = 18.424545 },
                new Hut { Id = 194, Name = "Cabañas Miami", Address = "Av Cnel R T F Dguez 1 Km 2 1/2", Longitude = -69.820379, Latitude = 18.491056 },
                new Hut { Id = 195, Name = "Cabañas Sabel", Address = "Carr S F V Tapia 30", Longitude = -70.286227, Latitude = 19.308399 },
                new Hut { Id = 196, Name = "Cabañas Sol y Luna", Address = "Aut San Isidro 1", Longitude = -69.823254, Latitude = 18.488673 },
                new Hut { Id = 197, Name = "Cabañas Turísticas La Alborada", Address = "", Longitude = -70.667468, Latitude = 19.445102 },
                new Hut { Id = 198, Name = "Cabañas Turísticas La Grandiosa", Address = "", Longitude = -70.2974, Latitude = 18.8903 },
                new Hut { Id = 199, Name = "Cabañas Turisticas Rubi", Address = "Carr Las Guarañas Km 3 1/2", Longitude = -70.22109, Latitude = 19.262809 },
                new Hut { Id = 200, Name = "Hotel El Encuentro", Address = "S Antonio 2", Longitude = -69.840227, Latitude = 18.590152 },
                new Hut { Id = 201, Name = "Hotel Las Magnolias", Address = "Anacaona 13", Longitude = -71.10686, Latitude = 18.206697 },
                new Hut { Id = 202, Name = "Hotel Medina", Address = "Av Anacaona Nte 94", Longitude = -71.2313, Latitude = 18.8103 },
                new Hut { Id = 203, Name = "Hotel La Gran Posada", Address = "", Longitude = -71.230838, Latitude = 18.811027 },
                new Hut { Id = 204, Name = "Hotel Boutique El Espia", Address = "", Longitude = -71.233584, Latitude = 18.806403 },
                new Hut { Id = 205, Name = "Hotel Maguana", Address = "", Longitude = -71.225591, Latitude = 18.806642 },
                new Hut { Id = 206, Name = "Hotel Pasión De Luna", Address = "", Longitude = -69.8072, Latitude = 18.5171 },
                new Hut { Id = 207, Name = "Hotel Poderoso", Address = "S Antonio 2", Longitude = -69.840227, Latitude = 18.590152 },
                new Hut { Id = 208, Name = "Motel Julling", Address = "A Meriño 31", Longitude = -69.034615, Latitude = 18.76264 },
                new Hut { Id = 209, Name = "Moteles Imperiales", Address = "Aut Duarte km 5 1/2", Longitude = -70.647808, Latitude = 19.418992 },
                new Hut { Id = 210, Name = "Paco Cabaña", Address = "Libertad 13", Longitude = -69.540407, Latitude = 19.321023 },
                new Hut { Id = 211, Name = "Residencia Del Paseo", Address = "", Longitude = -69.538874, Latitude = 19.321341 },
                new Hut { Id = 212, Name = "Condo Hotel Caribey", Address = "", Longitude = -69.541967, Latitude = 19.322463 },
                new Hut { Id = 213, Name = "Hotel Piedra Marron", Address = "", Longitude = -69.540745, Latitude = 19.318985 },
                new Hut { Id = 214, Name = "Super Cabañas Hollywood", Address = "Carr Pto Pta-Stgo Km 2", Longitude = -70.62288, Latitude = 19.712177 }
             );
            #endregion
        }
    }
}
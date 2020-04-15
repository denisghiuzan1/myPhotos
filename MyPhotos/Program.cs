using MyPhotos.Model;
using System;
using System.Collections.Generic;

namespace MyPhotos
{
    public class Program
    {
        public static int MAX_IMG_SIZE = 1000000;
        private static List<byte[]> files = new List<byte[]>();

        static void Main(string[] args)
        {
            TestManyToMany();
            Console.ReadKey();
        }

        public static void PersistImage(string path)
        {
            using (var context =
                new MyPhotosEntities())
            {
               
                context.SaveChanges();
            }
        }


        public static void TestManyToMany()
        {
            Console.WriteLine("Many to many association");
            using (var context =
                new MyPhotosEntities())
            {
                //var photo = new Photo
                //{
                //    CreationDate = DateTime.Now,
                //    Name = "Photo 1",
                //    IsDeleted = false,
                //    Path = " some shoit"
                //};

                //var person = new Person
                //{
                //    FirstName = "Chandler",
                //    LastName = "Bing"
                //};

                //var landscape = new Landscape
                //{
                //    Name = "Marea neagra",
                //    Description = "apa neagra"
                //};

                //var photoEvent = new Event
                //{
                //    Name = "bal mascat",
                //    Description = "ciori vopsite",
                //    Date = DateTime.Now.AddDays(-10)
                //};

                //var place = new Place
                //{
                //    Name = "China",
                //    Address = "15 Yemen Road Yemen",
                //    Description = "not today"
                //};

                //photo.Persons = new List<Person> { person };
                //photo.Events = new List<Event> { photoEvent };
                //photo.Landscapes = new List<Landscape> { landscape };
                //photo.Places = new List<Place> { place };

                //person.Photos = new List<Photo> { photo };
                //photoEvent.Photos = new List<Photo> { photo };
                //landscape.Photos = new List<Photo> { photo };
                //place.Photos = new List<Photo> { photo };

                //context.Photos.Add(photo);
                //context.Persons.Add(person);
                //context.Places.Add(place);
                //context.Events.Add(photoEvent);
                //context.Landscapes.Add(landscape);

                //var img = Image.FromFile("C:\\Users\\dghiuzan\\OneDrive - ENDAVA\\Desktop\\snow-south-germany.jpg");
                //MemoryStream tmpStream = new MemoryStream();
                //img.Save(tmpStream, ImageFormat.Png); // change to other format
                //tmpStream.Seek(0, SeekOrigin.Begin);
                //byte[] imgBytes = new byte[MAX_IMG_SIZE];
                //tmpStream.Read(imgBytes, 0, MAX_IMG_SIZE);

                //context.MediaFiles.Add(new MediaFile
                //{
                //    Payload = imgBytes,
                //    Photo = photo
                //});

                //context.SaveChanges();

                var items = context.Photos;
               foreach (var item in items)
               {
                   context.Photos.Remove(item);
                    //Console.WriteLine("Photo : {0}, {1}, {2}, {3}",
                    //    item.Id, item.Name, item.IsDeleted, photo.Path);
                    //foreach (var p in photo.Persons)
                    //    Console.WriteLine("\t Persons: {0}, {1}, {2}",
                    //        p.Id, p.FirstName, p.LastName);
                    //foreach (var e in photo.Events)
                    //    Console.WriteLine("\t Events: {0}, {1}, {2}, {3}",
                    //        e.Id, e.Date, e.Description, e.Name);
                    //foreach (var l in photo.Landscapes)
                    //    Console.WriteLine("\t Landscapes: {0}, {1}, {2}",
                    //        l.Id, l.Name, l.Description);
                    //foreach (var pl in photo.Places)
                    //    Console.WriteLine("\t Persons: {0}, {1}, {2}",
                    //        pl.Id, pl.Name, pl.Description);
                    //var media = photo.MediaFile;
                    //files.Add(media.Payload);
                    //Console.WriteLine("\t Persons: {0}, {1}",
                    //    media.Id, media.Payload.ToString());
                }
            }
        }
    }
}


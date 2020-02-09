using CryptoMiningSystem.Entities;
using CryptoMiningSystem.Entities.Components.Processors;
using CryptoMiningSystem.Entities.Components.VideoCards;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CryptoMiningSystem.Core
{
    public class PCController
    {
        private decimal totalProfits;
        private List<User> users;
        private List<Computer> computers;

        public PCController()
        {
            users = new List<User>();
            computers = new List<Computer>();
        }

        public string RegisterUser(List<string> args)
        {
            string name = args[0];
            decimal money = decimal.Parse(args[1]);

            if (users.Any(x => x.Name == name))
            {
                return $"Username: {name} already exists!";
            }
            else
            {
                users.Add(new User(name, money));
                return $"Successfully registered user - {name}!";
            }
        }

        public string CreateComputer(List<string> args)
        {
            string name = args[0];
            string processorType = args[1];
            string processorModel = args[2];
            int processorGeneration = int.Parse(args[3]);
            decimal processorPrice = decimal.Parse(args[4]);
            string videoCardType = args[5];
            string videoCardModel = args[6];
            int videoCardGeneration = int.Parse(args[7]);
            int videoCardRam = int.Parse(args[8]);
            decimal videoCardPrice = decimal.Parse(args[9]);
            int computerRam = int.Parse(args[10]);

            if (users.Any(x => x.Name == name))
            {
                Processor processor = null;
                if (processorType == "Low")
                {
                    processor = new LowPerformanceProcessor(processorModel, processorGeneration, processorPrice);
                }
                else if (processorType == "High")
                {
                    processor = new HighPerformanceProcessor(processorModel, processorGeneration, processorPrice);
                }
                else
                {
                    return $"Invalid type processor!";
                }


                VideoCard videoCard = null;
                if (videoCardType == "Game")
                {
                    videoCard = new GameVideoCard(videoCardModel, videoCardGeneration, videoCardRam, videoCardPrice);
                }
                else if (videoCardType == "Mine")
                {
                    videoCard = new MineVideoCard(videoCardModel, videoCardGeneration, videoCardRam, videoCardPrice);
                }
                else
                {
                    return $"Invalid type video card!";
                }

                decimal configurationPrice = videoCard.Price + processor.Price;

                if (configurationPrice > users.First(x => x.Name == name).Money)
                {
                    return $"User: {name} - insufficient funds!";
                }

                computers.Add(new Computer(processor, videoCard, computerRam));
                return $"Successfully created computer for user: {name}!";
            }
            else
            {
                return $"Username: {name} does not exist!";
            }
        }


        public string Mine()
        {
            decimal dailyProfits = 0M;

            foreach (var user in users
            .Where(x => x.Computer != null && x.Computer.Processor.LifeWorkingHours > 24 && x.Computer.VideoCard.LifeWorkingHours > 24))
            {
                user.Computer.Processor.LifeWorkingHours -= 24;
                user.Computer.VideoCard.LifeWorkingHours -= 24;
                decimal userGain = user.Computer.MinedAmountPerHour * 24;
                user.Money += userGain;
                dailyProfits += userGain;
            }

            totalProfits += dailyProfits;
            return $"Daily profits: {dailyProfits}!";

        }

        public string UserInfo(List<string> args)
        {
            string name = args[0];

            if (users.Any(x => x.Name == name))
            {
                var sb = new StringBuilder();

                var user = users.FirstOrDefault(x => x.Name == name);

                sb.AppendLine($"Name: {name} - Stars: {user.Stars}");
                sb.AppendLine($"Balance: {user.Money}");

                if (user.Computer != null)
                {
                    var pc = user.Computer;
                    var processor = pc.Processor;
                    var videoCard = pc.VideoCard;

                    string processorType = processor.GetType().Name;
                    string videoCardType = videoCard.GetType().Name;

                    sb.AppendLine($"PC Ram: {pc.Ram}");
                    sb.AppendLine($" - {processorType} – {processor.Model} – {processor.Generation}");
                    sb.AppendLine($" - {videoCardType} – {videoCard.Model} – {videoCard.Generation}");
                    sb.AppendLine($"   * Video card Ram: {videoCard.Ram}");
                }

                return sb.ToString().Trim();
            }
            else
            {
                return $"Username: {name} does not exist!";
            }
        }

        public string Shutdown()
        {
            var sb = new StringBuilder();

            foreach (var user in users.OrderByDescending(x => x.Stars))
            {
                sb.AppendLine($"Name: {user.Name} - Stars: {user.Stars}");
                sb.AppendLine($"Balance: {user.Money}");

                if (user.Computer != null)
                {
                    var pc = user.Computer;
                    var processor = pc.Processor;
                    var videoCard = pc.VideoCard;

                    string processorType = processor.GetType().Name;
                    string videoCardType = videoCard.GetType().Name;

                    sb.AppendLine($"PC Ram: {pc.Ram}");
                    sb.AppendLine($" - {processorType} – {processor.Model} – {processor.Generation}");
                    sb.AppendLine($" - {videoCardType} – {videoCard.Model} – {videoCard.Generation}");
                    sb.AppendLine($"   * Video card Ram: {videoCard.Ram}");
                }
            }

            sb.AppendLine($"System total profits: {totalProfits}!!!");

            return sb.ToString().Trim();
        }
    }
}

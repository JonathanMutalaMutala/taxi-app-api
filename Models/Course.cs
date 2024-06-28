namespace taxi_app_api.Models
{
    public class Course
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        // To do UserId 

        // Pour une course en particulier il faut avoir le chauffeur de la course 
        public CarOwner? Owner { get; set; }

        /// <summary>
        /// Répresente la destination de la course 
        /// </summary>
        public string DestinationAdress { get; set; } = string.Empty;

        /// <summary>
        /// Represente L'adresse que la course va commencer 
        /// </summary>
        public string OriginAdress { get; set; } = string.Empty; // Where the course started addresse

        /// <summary>
        /// Represente si La course a été marqué comme terminer 
        /// </summary>
        public bool IsEnded { get; set; }  

        /// <summary>
        /// Represente que la course a commencé
        /// </summary>
        public bool IsStarted { get; set; }

        /// <summary>
        /// Represente l'heure que la course va commencer 
        /// </summary>
        public DateTime StartedTime { get; set; }

        /// <summary>
        /// Represente l'heure de la fin de la course 
        /// </summary>
        public DateTime EndedTime { get; set; } 

    }
}

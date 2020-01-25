namespace DAL.DbContext
{
    using Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelData : DbContext   //IdentityDbContext  //
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « ModelData » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « DAL.DbContext.ModelData » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « ModelData » dans le fichier de configuration de l'application.
        public ModelData()
            : base("name=ModelData")
        {
           
        }
        //public virtual DbSet<IdentityRole> Roles { get; set; }
        //public virtual DbSet<ApplicationUser> Users { get; set; }
        //public virtual DbSet<IdentityUserClaim> UserClaims { get; set; }
        //public virtual DbSet<IdentityUserLogin> UserLogins { get; set; }
        //public virtual DbSet<IdentityUserRole> UserRoles { get; set; }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.
        //pour la mise à jour 
        //Enable-Migrations 
        //Add-Migration "InitialCreate02"
        //Update-Database
        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        //public enum Grade
        //{
        //   A, B, C, D, F
        //}
        //public Grade? Grade { get; set; }   La présence du point d’interrogation après la déclaration de type Grade indique que la propriété Grade accepte les valeurs Null.
        public DbSet<Tbl_Client> Tbl_Client{ get; set; }
        public DbSet<Tbl_Ville> Tbl_Ville { get; set; }
        public DbSet<Tbl_Region> Tbl_Region { get; set; }
        public DbSet<Tbl_Famille_Clt> Tbl_Famille_Clt { get; set; }
        public DbSet<Tbl_Contact_Clt> Tbl_Contact_clt { get; set; }
        public DbSet<Tbl_Service> Tbl_Service { get; set; }
        
    //View_Clt
}
    //Enable-Migrations
    //Add-Migration "InitialCreate"
    //Update-Database
    //POUR MIRGER ENTRE LES DEUX SPACE IDENTITY ET MODELDATA
    //https://social.msdn.microsoft.com/Forums/expression/en-US/61f2162e-cd07-46f9-a98a-4986408abd74/how-to-integrating-aspnet-identity-into-existing-dbcontext?forum=adodotnetentityframework
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    

}
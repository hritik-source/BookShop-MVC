using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bookshop.Models;

public partial class Ace42023Context : DbContext
{
    public Ace42023Context()
    {
    }

    public Ace42023Context(DbContextOptions<Ace42023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ArtUser> ArtUsers { get; set; }

    public virtual DbSet<Artistishan> Artistishans { get; set; }

    public virtual DbSet<Authorhritik> Authorhritiks { get; set; }

    public virtual DbSet<AvaniOrder> AvaniOrders { get; set; }

    public virtual DbSet<AvaniPerson> AvaniPersons { get; set; }

    public virtual DbSet<Bookhritik> Bookhritiks { get; set; }

    public virtual DbSet<Bookuserhritik> Bookuserhritiks { get; set; }

    public virtual DbSet<DeptFrp> DeptFrps { get; set; }

    public virtual DbSet<DeptRahul> DeptRahuls { get; set; }

    public virtual DbSet<EmpArpit> EmpArpits { get; set; }

    public virtual DbSet<EmpAvaneshwari> EmpAvaneshwaris { get; set; }

    public virtual DbSet<EmpBrijesh> EmpBrijeshes { get; set; }

    public virtual DbSet<EmpDaksh> EmpDakshes { get; set; }

    public virtual DbSet<EmpHarsh> EmpHarshes { get; set; }

    public virtual DbSet<EmpHarshitBranch> EmpHarshitBranches { get; set; }

    public virtual DbSet<EmpHritik> EmpHritiks { get; set; }

    public virtual DbSet<EmpIshwar> EmpIshwars { get; set; }

    public virtual DbSet<EmpJaivardhan> EmpJaivardhans { get; set; }

    public virtual DbSet<EmpMana> EmpManas { get; set; }

    public virtual DbSet<EmpPrem> EmpPrems { get; set; }

    public virtual DbSet<EmpSatyam> EmpSatyams { get; set; }

    public virtual DbSet<Empawanish> Empawanishes { get; set; }

    public virtual DbSet<Empharshit> Empharshits { get; set; }

    public virtual DbSet<Empishan> Empishans { get; set; }

    public virtual DbSet<Empprabhat> Empprabhats { get; set; }

    public virtual DbSet<EmpsRahul> EmpsRahuls { get; set; }

    public virtual DbSet<EmpsSameer> EmpsSameers { get; set; }

    public virtual DbSet<EmpsSuneet> EmpsSuneets { get; set; }

    public virtual DbSet<Empsuppawanish> Empsuppawanishes { get; set; }

    public virtual DbSet<LoginAwa> LoginAwas { get; set; }

    public virtual DbSet<ManasFerry> ManasFerries { get; set; }

    public virtual DbSet<ManasPort> ManasPorts { get; set; }

    public virtual DbSet<ManasTicket> ManasTickets { get; set; }

    public virtual DbSet<ManasUser> ManasUsers { get; set; }

    public virtual DbSet<Painting> Paintings { get; set; }

    public virtual DbSet<UserList> UserLists { get; set; }

    public virtual DbSet<UserPrem> UserPrems { get; set; }

    public virtual DbSet<Userbtl> Userbtls { get; set; }

    public virtual DbSet<Userbtlishan> Userbtlishans { get; set; }

    public virtual DbSet<Userhritik> Userhritiks { get; set; }

    public virtual DbSet<UsersRahul> UsersRahuls { get; set; }

    public virtual DbSet<Usertbl> Usertbls { get; set; }

    public virtual DbSet<Usertbl2> Usertbl2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEVSQL.corp.local;Database=ACE 4- 2023;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArtUser>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__art_user__DD70126488BB7E01");

            entity.ToTable("art_user");

            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Uname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("uname");
        });

        modelBuilder.Entity<Artistishan>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__artistis__DE508E2E425390CD");

            entity.ToTable("artistishan");

            entity.Property(e => e.Aid)
                .ValueGeneratedNever()
                .HasColumnName("aid");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Birthplace)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("birthplace");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.StyleOfWork)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("style_of_work");
        });

        modelBuilder.Entity<Authorhritik>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__authorhr__C6970A10555A5A05");

            entity.ToTable("authorhritik");

            entity.Property(e => e.Aid).ValueGeneratedNever();
            entity.Property(e => e.Aname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Place)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Speciality)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AvaniOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__avaniOrd__C3905BAFEEC2DAC7");

            entity.ToTable("avaniOrders");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");

            entity.HasOne(d => d.Person).WithMany(p => p.AvaniOrders)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__avaniOrde__Perso__6D0D32F4");
        });

        modelBuilder.Entity<AvaniPerson>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__avaniPer__AA2FFBE550F40911");

            entity.ToTable("avaniPersons");

            entity.Property(e => e.PersonId).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bookhritik>(entity =>
        {
            entity.HasKey(e => e.Bookid).HasName("PK__bookhrit__8BEA95C5A0B3FD2E");

            entity.ToTable("bookhritik");

            entity.Property(e => e.Bookid)
                .ValueGeneratedNever()
                .HasColumnName("bookid");
            entity.Property(e => e.Authorid).HasColumnName("authorid");
            entity.Property(e => e.Genre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("genre");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Year)
                .HasColumnType("date")
                .HasColumnName("year");

            entity.HasOne(d => d.Author).WithMany(p => p.Bookhritiks)
                .HasForeignKey(d => d.Authorid)
                .HasConstraintName("FK__bookhriti__autho__1F98B2C1");
        });

        modelBuilder.Entity<Bookuserhritik>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__bookuser__C5B69A4AC4341A6F");

            entity.ToTable("bookuserhritik");

            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Uname)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeptFrp>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__dept_frp__C03122187BC50FC9");

            entity.ToTable("dept_frp");

            entity.Property(e => e.Did).ValueGeneratedNever();
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfEmployees).HasColumnName("No_of_employees");
        });

        modelBuilder.Entity<DeptRahul>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__dept_rah__D877D216FF2C365C");

            entity.ToTable("dept_rahul");

            entity.Property(e => e.Did)
                .ValueGeneratedNever()
                .HasColumnName("did");
            entity.Property(e => e.Dname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dname");
        });

        modelBuilder.Entity<EmpArpit>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpArpit__D9509F6D748FA414");

            entity.ToTable("EmpArpit");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpAvaneshwari>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empAvane__D9509F6DDA2524D9");

            entity.ToTable("empAvaneshwari");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpBrijesh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empBrije__D9509F6DFBBCEE86");

            entity.ToTable("empBrijesh");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpDaksh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpDaksh__C1971B53E4E8E96D");

            entity.ToTable("EmpDaksh");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpHarsh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpHarsh__C1971B533A73B3F7");

            entity.ToTable("EmpHarsh");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpHarshitBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__empHarsh__3213E83F8083A385");

            entity.ToTable("empHarshitBranch");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("branch_name");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ename");

            entity.HasOne(d => d.Emp).WithMany(p => p.EmpHarshitBranches)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK__empHarshi__emp_i__73BA3083");
        });

        modelBuilder.Entity<EmpHritik>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empHriti__D9509F6D9EBABC74");

            entity.ToTable("empHritik");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpIshwar>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empIshwa__D9509F6D71EE07E4");

            entity.ToTable("empIshwar");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpJaivardhan>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empJaiva__D9509F6D2BCB7371");

            entity.ToTable("empJaivardhan");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<EmpMana>(entity =>
        {
            entity.HasKey(e => e.Eid);

            entity.ToTable("empManas");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpPrem>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empPrem__D9509F6D27559C2D");

            entity.ToTable("empPrem");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpSatyam>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpSatya__D9509F6D23134A4E");

            entity.ToTable("empSatyam");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Empawanish>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empawani__C1971B537D8161BB");

            entity.ToTable("empawanish");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.SId).HasColumnName("S_id");
            entity.Property(e => e.Salary).HasColumnName("salary");

            entity.HasOne(d => d.SIdNavigation).WithMany(p => p.Empawanishes)
                .HasForeignKey(d => d.SId)
                .HasConstraintName("FK__empawanish__S_id__68487DD7");
        });

        modelBuilder.Entity<Empharshit>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empharsh__D9509F6D853D881C");

            entity.ToTable("empharshit");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Empishan>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empishan__D9509F6DC5134935");

            entity.ToTable("empishan");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Empprabhat>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empprabh__D9509F6DB7BF358E");

            entity.ToTable("empprabhat");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpsRahul>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsRahu__D9509F6DEC4CB700");

            entity.ToTable("empsRahul");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Ecity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ecity");
            entity.Property(e => e.Edoj)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("edoj");
            entity.Property(e => e.Ename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Esal).HasColumnName("esal");
        });

        modelBuilder.Entity<EmpsSameer>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsSame__D9509F6D10A6543F");

            entity.ToTable("empsSameer");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Ecity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ecity");
            entity.Property(e => e.Edoj)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("edoj");
            entity.Property(e => e.Ename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Esal).HasColumnName("esal");
        });

        modelBuilder.Entity<EmpsSuneet>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsSune__D9509F6D3F2EB727");

            entity.ToTable("empsSuneet");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Ecity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ecity");
            entity.Property(e => e.Edoj)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("edoj");
            entity.Property(e => e.Ename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Esal).HasColumnName("esal");
        });

        modelBuilder.Entity<Empsuppawanish>(entity =>
        {
            entity.HasKey(e => e.SId).HasName("PK__empsuppa__A3DCCCA5B9ECAFAA");

            entity.ToTable("empsuppawanish");

            entity.Property(e => e.SId)
                .ValueGeneratedNever()
                .HasColumnName("S_id");
            entity.Property(e => e.Sname)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoginAwa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("login_awa");

            entity.Property(e => e.Pword)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("pword");
            entity.Property(e => e.Userid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("userid");
            entity.Property(e => e.Usernm)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("usernm");
        });

        modelBuilder.Entity<ManasFerry>(entity =>
        {
            entity.ToTable("ManasFerry");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Charge).HasColumnName("charge");
            entity.Property(e => e.Departure)
                .HasColumnType("datetime")
                .HasColumnName("departure");
            entity.Property(e => e.Destination).HasColumnName("destination");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Origin).HasColumnName("origin");
            entity.Property(e => e.RoomsLeft).HasColumnName("roomsLeft");

            entity.HasOne(d => d.DestinationNavigation).WithMany(p => p.ManasFerryDestinationNavigations)
                .HasForeignKey(d => d.Destination)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasFerry_ManasPort1");

            entity.HasOne(d => d.OriginNavigation).WithMany(p => p.ManasFerryOriginNavigations)
                .HasForeignKey(d => d.Origin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasFerry_ManasPort");
        });

        modelBuilder.Entity<ManasPort>(entity =>
        {
            entity.ToTable("ManasPort");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ManasTicket>(entity =>
        {
            entity.ToTable("ManasTicket");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AdultCount).HasColumnName("adultCount");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.FerryId).HasColumnName("ferryId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.RoomNo).HasColumnName("roomNo");

            entity.HasOne(d => d.Ferry).WithMany(p => p.ManasTickets)
                .HasForeignKey(d => d.FerryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasTicket_ManasFerry");
        });

        modelBuilder.Entity<ManasUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("ManasUser");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userId");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<Painting>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Painting__DD37D91A3E6137C2");

            entity.ToTable("Painting");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.ArtistId).HasColumnName("artist_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.StyleOfArt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("style_of_art");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Year)
                .HasColumnType("date")
                .HasColumnName("year");

            entity.HasOne(d => d.Artist).WithMany(p => p.Paintings)
                .HasForeignKey(d => d.ArtistId)
                .HasConstraintName("FK__Painting__artist__1CBC4616");
        });

        modelBuilder.Entity<UserList>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserList__1788CCACB1F20DE7");

            entity.ToTable("UserList");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<UserPrem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userPrem__3213E83F69169E0F");

            entity.ToTable("userPrem");

            entity.HasIndex(e => e.Username, "UQ__userPrem__F3DBC572C90E61BE").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Userbtl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__userbtl__1788CC4C1ACB02D1");

            entity.ToTable("userbtl");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Userbtlishan>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__userbtli__1788CC4C891106E7");

            entity.ToTable("userbtlishan");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Userhritik>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__userhrit__1797D024DBE43055");

            entity.ToTable("userhritik");

            entity.Property(e => e.Userid).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsersRahul>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__usersRah__DD7012643BA6E206");

            entity.ToTable("usersRahul");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.Uname)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("uname");
            entity.Property(e => e.Upswd)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("upswd");
        });

        modelBuilder.Entity<Usertbl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Usertbl__1788CC4C64DF7DCD");

            entity.ToTable("Usertbl");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usertbl2>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Usertbl2__1788CC4CD87FA2C4");

            entity.ToTable("Usertbl2");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

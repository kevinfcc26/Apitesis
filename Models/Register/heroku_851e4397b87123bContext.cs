using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiTesis.Models.Register
{
    public partial class heroku_851e4397b87123bContext : DbContext
    {
        public heroku_851e4397b87123bContext()
        {
        }

        public heroku_851e4397b87123bContext(DbContextOptions<heroku_851e4397b87123bContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Register> Register { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=us-cdbr-east-05.cleardb.net;port=3306;user=b62ba68668ea1c;password=4d0579fe;database=heroku_851e4397b87123b");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("register");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdhCal)
                    .HasColumnName("ADH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdiCal)
                    .HasColumnName("ADI_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdvCal)
                    .HasColumnName("ADV_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Afirms)
                    .HasColumnName("AFIRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Afvarhr)
                    .HasColumnName("AFVARHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Afvrms)
                    .HasColumnName("AFVRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Afwatthr)
                    .HasColumnName("AFWATTHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AihrmsCal)
                    .HasColumnName("AIHRMS_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Airms)
                    .HasColumnName("AIRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Aithd)
                    .HasColumnName("AITHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AnCal)
                    .HasColumnName("AN_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Angle0)
                    .HasColumnName("ANGLE0")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Angle1)
                    .HasColumnName("ANGLE1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Angle2)
                    .HasColumnName("ANGLE2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ap1Cal)
                    .HasColumnName("AP1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Apf)
                    .HasColumnName("APF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Apf1Cal)
                    .HasColumnName("APF1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AphCal)
                    .HasColumnName("APH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.As1Cal)
                    .HasColumnName("AS1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AshCal)
                    .HasColumnName("ASH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AsnCal)
                    .HasColumnName("ASN_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ava)
                    .HasColumnName("AVA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Avahr)
                    .HasColumnName("AVAHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Avar)
                    .HasColumnName("AVAR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Avarhr)
                    .HasColumnName("AVARHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AvhrmsCal)
                    .HasColumnName("AVHRMS_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Avrms)
                    .HasColumnName("AVRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Avthd)
                    .HasColumnName("AVTHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Awatt)
                    .HasColumnName("AWATT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Awatthr)
                    .HasColumnName("AWATTHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BdhCal)
                    .HasColumnName("BDH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BdiCal)
                    .HasColumnName("BDI_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BdvCal)
                    .HasColumnName("BDV_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bfirms)
                    .HasColumnName("BFIRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bfvarhr)
                    .HasColumnName("BFVARHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bfvrms)
                    .HasColumnName("BFVRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bfwatthr)
                    .HasColumnName("BFWATTHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BihrmsCal)
                    .HasColumnName("BIHRMS_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Birms)
                    .HasColumnName("BIRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bithd)
                    .HasColumnName("BITHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BnCal)
                    .HasColumnName("BN_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bp1Cal)
                    .HasColumnName("BP1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bpf)
                    .HasColumnName("BPF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bpf1Cal)
                    .HasColumnName("BPF1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BphCal)
                    .HasColumnName("BPH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bs1Cal)
                    .HasColumnName("BS1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BshCal)
                    .HasColumnName("BSH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BsnCal)
                    .HasColumnName("BSN_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bva)
                    .HasColumnName("BVA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bvahr)
                    .HasColumnName("BVAHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bvar)
                    .HasColumnName("BVAR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bvarhr)
                    .HasColumnName("BVARHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BvhrmsCal)
                    .HasColumnName("BVHRMS_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bvrms)
                    .HasColumnName("BVRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bvthd)
                    .HasColumnName("BVTHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bwatt)
                    .HasColumnName("BWATT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bwatthr)
                    .HasColumnName("BWATTHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CdhCal)
                    .HasColumnName("CDH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CdiCal)
                    .HasColumnName("CDI_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CdvCal)
                    .HasColumnName("CDV_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cfirms)
                    .HasColumnName("CFIRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cfvarhr)
                    .HasColumnName("CFVARHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cfvrms)
                    .HasColumnName("CFVRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cfwatthr)
                    .HasColumnName("CFWATTHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CihrmsCal)
                    .HasColumnName("CIHRMS_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cirms)
                    .HasColumnName("CIRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cithd)
                    .HasColumnName("CITHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CnCal)
                    .HasColumnName("CN_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cp1Cal)
                    .HasColumnName("CP1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CpCal)
                    .HasColumnName("CP_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf1Cal)
                    .HasColumnName("CPF1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CphCal)
                    .HasColumnName("CPH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cs1Cal)
                    .HasColumnName("CS1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CshCal)
                    .HasColumnName("CSH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CsnCal)
                    .HasColumnName("CSN_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cva)
                    .HasColumnName("CVA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cvahr)
                    .HasColumnName("CVAHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cvar)
                    .HasColumnName("CVAR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cvarhr)
                    .HasColumnName("CVARHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CvhrmsCal)
                    .HasColumnName("CVHRMS_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cvrms)
                    .HasColumnName("CVRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cvthd)
                    .HasColumnName("CVTHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cwatt)
                    .HasColumnName("CWATT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cwatthr)
                    .HasColumnName("CWATTHR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Datetime).HasColumnName("DATETIME");

                entity.Property(e => e.DehCal)
                    .HasColumnName("DEH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DeiCal)
                    .HasColumnName("DEI_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DevCal)
                    .HasColumnName("DEV_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ie1Cal)
                    .HasColumnName("IE1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IeCal)
                    .HasColumnName("IE_CAl")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IehCal)
                    .HasColumnName("IEH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Isum)
                    .HasColumnName("ISUM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nirms)
                    .HasColumnName("NIRMS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PeCal)
                    .HasColumnName("PE_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PehCal)
                    .HasColumnName("PEH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PfeCal)
                    .HasColumnName("PFE_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Se1Cal)
                    .HasColumnName("SE1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SeCal)
                    .HasColumnName("SE_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SehCal)
                    .HasColumnName("SEH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SenCal)
                    .HasColumnName("SEN_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ThdeiCal)
                    .HasColumnName("THDEI_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ThdevCal)
                    .HasColumnName("THDEV_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Vab1Cal)
                    .HasColumnName("VAB1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VabCal)
                    .HasColumnName("VAB_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VabhCal)
                    .HasColumnName("VABH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Vbc1Cal)
                    .HasColumnName("VBC1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VbcCal)
                    .HasColumnName("VBC_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VbchCal)
                    .HasColumnName("VBCH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Vca1Cal)
                    .HasColumnName("VCA1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VcaCal)
                    .HasColumnName("VCA_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VcahCal)
                    .HasColumnName("VCAH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ve1Cal)
                    .HasColumnName("VE1_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VeCal)
                    .HasColumnName("VE_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VehCal)
                    .HasColumnName("VEH_CAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("test");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

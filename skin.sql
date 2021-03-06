USE [master]
GO
/****** Object:  Database [skin_cilinic]    Script Date: 12/13/2018 10:53:58 PM ******/
CREATE DATABASE [skin_cilinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'skin_cilinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\skin_cilinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'skin_cilinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\skin_cilinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [skin_cilinic] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [skin_cilinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [skin_cilinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [skin_cilinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [skin_cilinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [skin_cilinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [skin_cilinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [skin_cilinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [skin_cilinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [skin_cilinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [skin_cilinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [skin_cilinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [skin_cilinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [skin_cilinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [skin_cilinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [skin_cilinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [skin_cilinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [skin_cilinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [skin_cilinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [skin_cilinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [skin_cilinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [skin_cilinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [skin_cilinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [skin_cilinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [skin_cilinic] SET RECOVERY FULL 
GO
ALTER DATABASE [skin_cilinic] SET  MULTI_USER 
GO
ALTER DATABASE [skin_cilinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [skin_cilinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [skin_cilinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [skin_cilinic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [skin_cilinic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [skin_cilinic] SET QUERY_STORE = OFF
GO
USE [skin_cilinic]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [skin_cilinic]
GO
/****** Object:  UserDefinedTableType [dbo].[ty_many]    Script Date: 12/13/2018 10:53:59 PM ******/
CREATE TYPE [dbo].[ty_many] AS TABLE(
	[pid] [int] NULL,
	[qty] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ty_string]    Script Date: 12/13/2018 10:53:59 PM ******/
CREATE TYPE [dbo].[ty_string] AS TABLE(
	[string] [int] NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[fn_check_login]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[fn_check_login](@u nvarchar(max),@p nvarchar(30))
returns bit as
begin
declare @test bit
if((select [user_id] from tbl_user where [user_id]=@u and user_password=@p)is not null)
	set @test='true'
else
	set @test='false'
return @test
end 

GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_sup]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[fn_get_sup](@id int)
RETURNS float as
BEGIN
declare @sup money
select @sup=pro_sup from tbl_product where pro_id=@id
return @sup
END


GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_upis]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[fn_get_upis](@id int)
RETURNS float as
BEGIN
declare @up money
select @up=pro_upis from tbl_product where pro_id=@id
return @up
END


GO
/****** Object:  Table [dbo].[tbl_import_detail]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_import_detail](
	[imp_id] [int] NOT NULL,
	[pro_id] [int] NOT NULL,
	[qty] [int] NULL,
 CONSTRAINT [pk_import] PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC,
	[imp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_product]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_product](
	[pro_id] [int] NOT NULL,
	[pro_name] [nvarchar](max) NULL,
	[cat_id] [int] NULL,
	[pro_sup] [float] NULL,
	[pro_upis] [float] NULL,
	[pro_qty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_import]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[fn_get_import](@ii int)
returns table as return 
select imp_id,(select min(pro_name) from tbl_product where tbl_import_detail.pro_id=pro_id)as Name,pro_id,qty from tbl_import_detail where imp_id=@ii


GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_product_by_cat]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[fn_get_product_by_cat](@ci int)
returns table 
as return
select pro_id,pro_name,cat_id,pro_sup,pro_upis from tbl_product
where cat_id=@ci


GO
/****** Object:  Table [dbo].[tbl_import]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_import](
	[imp_id] [int] NOT NULL,
	[imp_date] [datetime] NULL,
	[imp_total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[imp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_get_import]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_get_import]
as
select * from tbl_import

GO
/****** Object:  Table [dbo].[tbl_order]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_order](
	[ord_id] [int] NOT NULL,
	[ord_date] [datetime] NULL,
	[ord_total] [float] NULL,
	[cus_id] [int] NULL,
	[consulation] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ord_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_order_detail]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_order_detail](
	[ord_id] [int] NOT NULL,
	[pro_id] [int] NOT NULL,
	[qty] [int] NULL,
 CONSTRAINT [pk_order] PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC,
	[ord_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_get_order]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[vw_get_order] as
	select ord.ord_id,ord.ord_total,
	(select max(pro_name)from tbl_product where pro_id=ordd.pro_id) as [Product Name],
	(select pro_sup*qty from tbl_product where pro_id=ordd.pro_id) as [Price],
	ordd.qty from tbl_order ord  join tbl_order_detail ordd on 
	ord.ord_id=ordd.ord_id


GO
/****** Object:  Table [dbo].[tbl_catagory]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_catagory](
	[cat_id] [int] NOT NULL,
	[cat_name] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_customer]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_customer](
	[cus_id] [int] NOT NULL,
	[cus_name] [nvarchar](max) NULL,
	[cus_address] [nvarchar](max) NULL,
	[cus_phone] [nvarchar](max) NULL,
	[cus_gender] [nvarchar](10) NULL,
	[cus_dob] [date] NULL,
	[cus_occupation] [nvarchar](10) NULL,
	[cus_age] [int] NULL,
 CONSTRAINT [PK__tbl_cust__E84D41E8C75EB761] PRIMARY KEY CLUSTERED 
(
	[cus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_history]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_history](
	[cus_id] [int] NULL,
	[skin_examination] [nvarchar](max) NULL,
	[inverstigation] [nvarchar](max) NULL,
	[location] [nvarchar](max) NULL,
	[diagnostics] [nvarchar](max) NULL,
	[his_id] [int] NULL,
	[level] [int] NULL,
	[history] [nvarchar](max) NULL,
	[date] [date] NULL,
	[prescription] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[user_id] [nvarchar](30) NOT NULL,
	[user_password] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_history]  WITH CHECK ADD  CONSTRAINT [FK__tbl_histo__cus_i__398D8EEE] FOREIGN KEY([cus_id])
REFERENCES [dbo].[tbl_customer] ([cus_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_history] CHECK CONSTRAINT [FK__tbl_histo__cus_i__398D8EEE]
GO
ALTER TABLE [dbo].[tbl_import_detail]  WITH CHECK ADD  CONSTRAINT [FK__tbl_impor__imp_i__300424B4] FOREIGN KEY([imp_id])
REFERENCES [dbo].[tbl_import] ([imp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_import_detail] CHECK CONSTRAINT [FK__tbl_impor__imp_i__300424B4]
GO
ALTER TABLE [dbo].[tbl_import_detail]  WITH CHECK ADD  CONSTRAINT [FK__tbl_impor__pro_i__30F848ED] FOREIGN KEY([pro_id])
REFERENCES [dbo].[tbl_product] ([pro_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_import_detail] CHECK CONSTRAINT [FK__tbl_impor__pro_i__30F848ED]
GO
ALTER TABLE [dbo].[tbl_order]  WITH CHECK ADD  CONSTRAINT [FK__tbl_order__cus_i__4AB81AF0] FOREIGN KEY([cus_id])
REFERENCES [dbo].[tbl_customer] ([cus_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_order] CHECK CONSTRAINT [FK__tbl_order__cus_i__4AB81AF0]
GO
ALTER TABLE [dbo].[tbl_order_detail]  WITH CHECK ADD  CONSTRAINT [FK__tbl_order__ord_i__4CA06362] FOREIGN KEY([ord_id])
REFERENCES [dbo].[tbl_order] ([ord_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_order_detail] CHECK CONSTRAINT [FK__tbl_order__ord_i__4CA06362]
GO
ALTER TABLE [dbo].[tbl_order_detail]  WITH CHECK ADD  CONSTRAINT [FK__tbl_order__pro_i__4D94879B] FOREIGN KEY([pro_id])
REFERENCES [dbo].[tbl_product] ([pro_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_order_detail] CHECK CONSTRAINT [FK__tbl_order__pro_i__4D94879B]
GO
ALTER TABLE [dbo].[tbl_product]  WITH CHECK ADD FOREIGN KEY([cat_id])
REFERENCES [dbo].[tbl_catagory] ([cat_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_product]  WITH CHECK ADD CHECK  (([pro_qty]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[sp_get_customer]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_get_customer](@ci int)
as begin
select *,DATEDIFF(YEAR,cus_dob,GETDATE())+cus_age as age from tbl_customer
where cus_id=@ci
end

GO
/****** Object:  StoredProcedure [dbo].[sp_get_customer_phone]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_get_customer_phone](@cp nvarchar(10))
as
begin
	select * from tbl_customer where cus_phone= @cp
end

GO
/****** Object:  StoredProcedure [dbo].[sp_get_history]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_get_history](@ci int)
as begin
	select his_id,[date] as [Date],history as History,skin_examination as [Skin Examination],
	inverstigation as Investigation,location as Location,
	diagnostics as Diagnostics,[level]as [Level],prescription from tbl_history
	where cus_id=@ci
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insert_cat]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insert_cat](@cn nvarchar(max))
as 
begin
declare @ci int
	if((select max(cat_id)from tbl_catagory)is null)
		set @ci=1
	else
		set @ci=(select max(cat_id)from tbl_catagory)+1
insert into tbl_catagory values(@ci,@cn)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insert_customer]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insert_customer]
(
  @cn nvarchar(max),
  @ca nvarchar(max),
  @cp nvarchar(11),
  @cg nvarchar(10),
  @cage int,
  @co nvarchar(max)
)
as
begin
  declare @ci int
  if((select max(cus_id)from tbl_customer)is null)
    set @ci=1 
  else
    select @ci=max(cus_id)+1from tbl_customer
  INSERT INTO tbl_customer(cus_id,cus_name,cus_address,cus_phone,cus_gender,cus_dob,cus_occupation,cus_age)
  VALUES(@ci,@cn,@ca,@cp,@cg,GETDATE(),@co,@cage)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_history]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insert_history]
(
	@ci int,
	@sk nvarchar(max),
	@iv nvarchar(max),
	@lc nvarchar(max),
	@dg nvarchar(max),
	@lv int,
	@his nvarchar(max),
	@pre nvarchar(max)
)
as 
begin
	declare @hi int
	if((select max(his_id)from tbl_history)is null)
		set @hi=1
	else
		select @hi=max(his_id)+1from tbl_history
	insert into tbl_history (cus_id,skin_examination,inverstigation,location,diagnostics,his_id,[level],history,[date],prescription) 
	values (@ci,@sk,@iv,@lc,@dg,@hi,@lv,@his,GETDATE(),@pre)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insert_import]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_insert_import](@y ty_many readonly)
as
begin
declare @ii int
if((select max(imp_id) from tbl_import)is null)
	set @ii=1
else
	set @ii=1+(select max(imp_id)from tbl_import)
insert into tbl_import(imp_id,imp_date,imp_total) values(@ii,GETDATE(),
(select sum(qty*dbo.fn_get_upis(pid))from @y))
insert into tbl_import_detail select @ii,pid,qty from @y  
UPdate tbl_Product set pro_qty+=
(select qty from @y where pid=tbl_product.pro_Id)
from tbl_Product inner join @y t
on t.pId=tbl_Product.pro_Id
end






GO
/****** Object:  StoredProcedure [dbo].[sp_insert_order]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_insert_order](@y ty_many readonly,@cui int=null,@con float=null)
as
begin
declare @ii int
if((select max(ord_id) from tbl_order)is null)
	set @ii=1
else
	set @ii=1+(select max(ord_id)from tbl_order)
insert into tbl_order(ord_id,ord_date,ord_total,consulation,cus_id) values(@ii,GETDATE(),
(select sum(qty*dbo.fn_get_sup(pid))+@con from @y),@con,@cui)
declare @sum float
insert into tbl_order_detail(ord_id,pro_id,qty) select @ii,pid,qty from @y
select @sum=qty*(select max(pro_upis) 
from tbl_product where pro_id=pro_id)from tbl_order_detail
UPdate tbl_Product set pro_qty-=
(select qty from @y where pid=tbl_product.pro_Id)
from tbl_Product inner join @y t
on t.pId=tbl_Product.pro_Id
end






GO
/****** Object:  StoredProcedure [dbo].[sp_insert_product]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insert_product]
(@pn nvarchar(max),@ci int=null,@ps float,@pu float,@q int,@cn nvarchar(max)=null)
as
begin

declare @pi int
	if((select max(pro_id)from tbl_product)is null)
		set @pi=1
	else
		set @pi=(select max(pro_id)from tbl_product)+1
if(@ci is null and @cn is not null)
BEGIN
	exec sp_insert_cat @cn=@cn
	select @ci=max(cat_id) from tbl_catagory
END
	insert into tbl_product values(@pi,@pn,@ci,@ps,@pu,@q)

end

GO
/****** Object:  StoredProcedure [dbo].[sp_insert_user]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[sp_insert_user](@u nvarchar(max),@p nvarchar(30))
as
begin
	insert into tbl_user values(@u,@p)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_select_history1]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_select_history1](@ci int,@hi int)
as
begin
SET NOCOUNT ON;
select * from tbl_customer inner join tbl_history on tbl_customer.cus_id=tbl_history.cus_id where his_id=@hi and tbl_customer.cus_id=@ci
end

GO
/****** Object:  StoredProcedure [dbo].[sp_update_cat]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_update_cat](@ci int,@cn nvarchar(max))
as
begin
	update tbl_catagory set cat_name=@cn where cat_id=@ci
end

GO
/****** Object:  StoredProcedure [dbo].[sp_update_customer]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_update_customer]
(	
	@ci int,
	@cn nvarchar(max),
	@ca nvarchar(max),
	@cp nvarchar(11),
	@cg nvarchar(10),
	@co nvarchar(max),
	@cage int
)
as
begin

	 UPDATE  tbl_customer set 
	 cus_name=@cn,cus_address=@ca,cus_phone=@cp,cus_gender=@cg,cus_occupation=@co,cus_age=@cage,cus_dob=GETDATE()
	 where cus_id=@ci

end

GO
/****** Object:  StoredProcedure [dbo].[sp_update_import]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_update_import]
(
	@ii int,
	@pi int,
	@iq int
)
as
begin
	declare @all int
	declare @qty int
	select @qty=qty from tbl_import_detail where imp_id=@ii and pro_id=@pi
	
	set @all=@iq-@qty

	update tbl_import_detail set imp_id=@ii,pro_id=@pi,qty=@iq
	where pro_id=@pi and imp_id=@ii
	update tbl_product set pro_qty+=@all where pro_id=@pi
	update tbl_import set imp_total=(select sum(qty*dbo.fn_get_upis(pro_id)) from tbl_import_detail where imp_id=@ii group by imp_id)
	where imp_id=@ii
end
select * from tbl_import_detail
select * from tbl_product

GO
/****** Object:  StoredProcedure [dbo].[sp_update_order]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_update_order]
(
	@oi int,
	@pi int,
	@oq int
)
as
begin
	update tbl_order_detail set ord_id=@oi,pro_id=@pi,qty=@oq
	where pro_id=@pi and ord_id=@oi
	update tbl_product set pro_qty-=@oq
	update tbl_order set ord_total=(select sum(qty*dbo.fn_get_sup(pro_id)) from tbl_order_detail where ord_id=@oi group by ord_id)
	where ord_id=@oi
end


GO
/****** Object:  StoredProcedure [dbo].[sp_update_user]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[sp_update_user](@u nvarchar(max),@p nvarchar(30))
as
begin
	update tbl_user set [user_id]=@u,user_password=@p
	where [user_id]=@u
end

GO
/****** Object:  StoredProcedure [dbo].[update_password]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_password](@ui nvarchar(max),@p nvarchar(max))
as
begin
  update tbl_user set user_password=@p  where user_id=@ui
end

GO
/****** Object:  StoredProcedure [dbo].[update_product]    Script Date: 12/13/2018 10:53:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_product](@pi int,@pn nvarchar(max),@ps float,@up float)
as
begin
update tbl_product set pro_name=@pn,pro_sup=@ps,pro_upis=@up
where pro_id=@pi
end

GO
USE [master]
GO
ALTER DATABASE [skin_cilinic] SET  READ_WRITE 
GO

﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgrammersBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Categories (Name,Description,Note,CreatedDate,CreatedByName,ModifiedDate,ModifiedByName,IsActive,IsDeleted) VALUES ('Python','Python Dili ile İlgili En Güncel Bilgiler','Python Kategorisi',GETDATE(),'Migration',GETDATE(),'Migration',1,0)");
            migrationBuilder.Sql(
                            "INSERT INTO Categories (Name,Description,Note,CreatedDate,CreatedByName,ModifiedDate,ModifiedByName,IsActive,IsDeleted) VALUES ('Java','Java Dili ile İlgili En Güncel Bilgiler','Java Kategorisi',GETDATE(),'Migration',GETDATE(),'Migration',1,0)");
            migrationBuilder.Sql(
                            "INSERT INTO Categories (Name,Description,Note,CreatedDate,CreatedByName,ModifiedDate,ModifiedByName,IsActive,IsDeleted) VALUES ('Dart','Dart Dili ile İlgili En Güncel Bilgiler','Dart Kategorisi',GETDATE(),'Migration',GETDATE(),'Migration',1,0)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}

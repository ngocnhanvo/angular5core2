using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Angular5asp2.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

public class PublicFunction
{
    private aspnetcoreContext db = null;
    public static string connectstring = "";
    public PublicFunction(aspnetcoreContext _db)
    {
        if(_db == null) {
            db = new aspnetcoreContext();
        }
        else
        {
            db = _db;
        }
    }

    public AdUser priavte_infoUser()
    {
        AdUser user_name = db.AdUser.FirstOrDefault(s => s.Active == true);
        return user_name;
    }

    public static string Newid()
    {
        return Guid.NewGuid().ToString().Replace("-","");
    }
}

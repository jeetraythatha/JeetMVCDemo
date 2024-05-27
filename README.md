# JeetMVCDemo
DemoMVC Rise Batch

1. Repository Pattern Link https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/
2. difference between and ASP.net Core MVC v/s ASP.net MVC Link
3.   1. https://www.interviewbit.com/blog/net-core-vs-net-framework/#:~:text=NET%20Framework%20is%20a%20platform,app%20needs%20and%20developer%20workflows.
     2. https://learn.microsoft.com/en-us/dotnet/standard/choosing-core-framework-server
     3. https://www.geeksforgeeks.org/differences-between-net-core-and-net-framework/
     4. https://www.c-sharpcorner.com/article/asp-net-mvc-vs-asp-net-core/#:~:text=The%20distinctions%20between%20ASP.NET,modular%2C%20and%20boasts%20improved%20performance.
     5. https://www.scholarhat.com/tutorial/aspnet/difference-between-aspnet-mvc5-and-aspnet-core
        1. In ASP.net MVC Windows is the only platform for ASP.NET MVC. and in ASP.net core MVC it is Compatible with Mac OS X, Windows, and Linux.
4. What is ASP.net Core? Link==> **https://www.c-sharpcorner.com/article/what-is-dot-net-core/**
     1. https://radixweb.com/blog/net-core-vs-net-framework ==>>**Read this to clear your doubt in .Net Framework V/S .Net Core**
     2. https://www.mygreatlearning.com/blog/net-core-vs-net-framework/#:~:text=Net%20Core%20is%20the%20up,execute%20based%20only%20on%20Windows.
5. Links For AutoMapper.
     1. https://medium.com/@supino0017/automapper-for-object-mapping-in-net-8-5b20a034de8c
     2. https://stackoverflow.com/questions/40275195/how-to-set-up-automapper-in-asp-net-core
6. Links For EntityFrameworkCore https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx
7. Link Angular Material Table with pagination => https://material.angular.io/components/table/overview
8.** MVC Links
       1. https://www.tutorialsteacher.com/mvc/action-filters-in-mvc
       2. https://www.c-sharpcorner.com/article/filters-in-Asp-Net-mvc-5-0-part-twelve/
       3. https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/understanding-action-filters-cs
       4. html Helpers = https://www.tutorialsteacher.com/mvc/html-helpers
       5. validations =  https://www.tutorialsteacher.com/mvc/implement-validation-in-asp.net-mvc
       6. https://www.tutorialsteacher.com/mvc/partial-view-in-asp.net-mvc
       7. viewBag =  https://www.tutorialsteacher.com/mvc/viewbag-in-asp.net-mvc
       8. ViewData = https://www.tutorialsteacher.com/mvc/viewdata-in-asp.net-mvc
       9. Tempdata = https://www.tutorialsteacher.com/mvc/tempdata-in-asp.net-mvc
       10. https://www.tutorialsteacher.com/mvc/filters-in-asp.net-mvc
**


**DATE ISSUE**
Add Following Provider Object in app.module.ts
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { DatePipe } from '@angular/common';
  providers: [
   
    DatePipe,
    {
      provide: MAT_DATE_LOCALE,useValue:'en-GB'
    }
  ],
Use the following to convert the date formate
import { DatePipe } from '@angular/common';
constructor(public datePipe: DatePipe,) { }

    this.startDate = this.datePipe.transform(this.startDate, 'yyyy-MM-dd');
    this.endDate = this.datePipe.transform(this.endDate, 'yyyy-MM-dd');

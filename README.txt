NuGet Package Manager
---------------------
This solution uses NuGet Package Manager and you will have to enable the following option to build this solution.
--Tools -> Options -> Package Manager -> General -> Package Restore -> Tick "Allow NuGet to download missing packages during build"

You can use the Package Manager to see what packages were required.

MVC 4
-----

Database
--------
Take care here as the NHibernate SessionFactory creation will remove your current database everytime it is run.
This will happen for every call to SessionFactory. This is most certainly not ideal for a live site and probably
should be managed via a different mechanism.

I have set this up with PostgreSQL db so you will have to install Postgre. 
Create a database called "MVCApp1", a Login Role "mvcuser" with a password "mvcpassword",
with a right that can create database objects. Or if you would like to change 
these then you can update the connection string in the PostgreDatabaseConfigurer.
 
Or you can easily change to the database of your choice that NHibernate supports.
All you will need to do is create an implementation of IDatabaseConfigurer (take a look at PostGreDatabaseConfigurer).
Also you will need to modify the Ninject binding of IDatabaseConfigurer to bind to your implementation of the interface,
this is found in the NHibernateModule.cs file. 
i.e. For SQliteDatabase Bind<IDatabaseConfigurer>.To<SQliteDatabaseConfigurer>

Dependency Injection
--------------------
This currently uses Ninject 3 and the Ninject.MVC 3. This currently works for MVC 4.

Application details
-------------------
Currently when it starts it looks like the MVC 4 default setup, but also contains a new menu item "Products" 
this is where I have used a connection to the database to retrieve a list of products.
By default there are no products added and this list will be empty. If you add some rows to the "Products" table
a refresh of the Products page will show the newly added products.

NHibernate's SessionFactory and Session are controlled via Ninject using the bindings defined in the NHibernateModule.
The SessionFactory is InSingletonScope and the Session is InRequestScope. Making the Session InRequestScope allows 
the Session to be controlled by Ninject, so for every new HTTP Request and request of a Session a new one will be created, 
otherwise if there are many requests to a Session that is on the same HTTP Request then the same Session will be used.

I have decided not to use the UnitOfWork pattern any where as I believe I can do the transaction management via a filter, 
I am still thinking/working on this.

I have also decided not to go with using a Repository pattern as I also believe from reading lots of Ayende's posts, 
various others, and a past experience of using it, that it is limiting the API of NHibernate to be able to make optimal
calls to the database. Maybe if there was no NHibernate, then it would be more useful. So you will see a plain call
in the ProductController.Index on the session to retrieve all the products.

Transactions are also controlled via Ninject, where the TransactionAttribute is added to the methods that require access
to the database. Ninject will then bind the TransactionFilter to this method/action.

Logging can also be setup the same way as Transactions are, I have not done this yet.


# 2 - C# Basics

Building upon the basic applications in the 1st section.
This example contains a procedural example of determinine the sales price depending on what county you are in as well as a class based example.

In the class based example, the logic determining the sales tax for each county is spread into multiple separate classes with a provider class to determine the sales tax to use depending on county provided.
While this seems like a lot of extra work for the same result, it provides a separation of of logic so changes to one county cannot accidently introduce bugs in another.
It also provides a nice, encapulation of each county's logic so future tax information could be added to each one and the provider would handle all of the if/switch logic when determining business rules.



 ## Notes:


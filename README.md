this repo shows how you can use generically typed entities with ef core

my test here was in response to my current companies unorthadox way of querying different types of entities and how objects with similar purposes have no relation to eachother, despite needing to interact with eachother

this solution shows how we can have a shared base type for different permutations of the same IRL concept (clients here)

with this we can treat them all as the same 'thing' but act differently depending on the generic type we pass in. like Client who is an individual

this is pretty simple normally, but with the inclusion of a DB the complexity increases. EF core can handle this gracefully using this solution

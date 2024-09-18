# Fokus

in 8 Stunden soll ein Projekt umgesetzt werden.

# Anforderungen

- ich verwende C# zum ersten mal.
- soll ne GUI mit Windows Forms erstellt haben
- die nutzer sollen identitaeten haben
- es soll einen Marktplatz geben
- jeder nutzer soll Angebote veroeffentlichen koennen
- die App muss nicht netzwerkfaehig sein.
- es soll eine internationale Waehrung geben
- Waehrungen sollen wie Produkte behandelt werden
- die Einheiten einer Waehrung soll durch hashing und public key crypto faelschungssicher gemacht werden.
- die Waehrungen sind Fiat.
- das praegen internationaler Waehrungseinheiten ist nur durch die signaturen aller beteiligten moeglich.


# Zeitliche planung

- ich mag scrum, hab aber vergessen wies geht, versuche es aufgrund der guten Erinnerungen zu benutzen.
- hierfuer braucht man erstmal des Product Backlog..

# Product Backlog

- pgp : sign, verify, keyring, trust
- winforms
- marktplatz: database: store offers
- create offers (and sign them)
- trade: take offers
- multisig product creation
- documentation

# nochmal Product Backlog

- pgp
- hashing
- database
- winform
- database, offer handling: create and take
- docu


# Acceptance Criteria

## pgp
user have a keypair, can sign, import other keys, verify signatures

## database
create, insert and delete entries

# winform:
	marketplace
		create offer (verify)
		take offer 
	create product
		define promise
		sign it
	enter the market
		create identity
			random
		login
			no username password shit, just one key to enter
		logout
	
# sprint planning
 sprints are 1 hour long

 ## backlog item investment definition

 pgp 1 hour
 gui 1 hour
 database 1 hour
 docu 0 hour

 sprintplanning:
 1st sprint pgp
 2nd sprint database
 3rd sprint gui

 # 1st Sprint
 
- 60 min learning visual studio to load the right template, sync it with git, and find out where to write backend code ...

## Sprint Review:
 
 - Stakeholder: have no hope for profit.

## retrospective

gui is a depencency for backend code if you don't know how c# works...
now knowing c# is a dependency to know where to put your backend code...
add: c# training to backlog.

## new capital calculation

c# training: 1/3 hours
pgp:           1 hour
database:      1 hour
winform:       1 hour

total:		   1/8 hours

celebration: yeay, we are a little bit more familiar with c# visual studio windows forms!!!

next sprint:

2# training  
goal: find out where to put backend code... 

## end sprint 1
## --------------------------------------------------------------------------
## start sprint 2

## Sprint Review:
 
 - Stakeholder: have no hope for profit.

## retrospective

program starts in Program.cs in static void Main.

## new capital calculation

c# training: 2/3 hours
pgp:           1 hour
database:      1 hour
winform:       1 hour

total:		   2/8 hours

celebration: yeay, we are a little bit more familiar with c# visual studio project structure.

next sprint:
winforms create all windows and buttons

## end sprint 2
## --------------------------------------------------------------------------
## start sprint 3

## Sprint Review:
 
we have a database and a connection.
 - Stakeholder: have no hope for profit.

## retrospective

if there are some open questions leave them open. get things done with tools you don't understand. goal is not the mastery of a toolset. it's shipping a product.

## new capital calculation

c# training: 2/3 hours
pgp:           1 hour
database:     1/2 hour
winform:       1 hour

total:		   3/8 hours

next sprint:
winforms create all windows and buttons

## end sprint 3
## --------------------------------------------------------------------------
## start sprint 4


## Sprint Review:
 
we have a database and a connection.
 - Stakeholder: have no hope for profit.

## retrospective

if there are some open questions leave them open. get things done with tools you don't understand. goal is not the mastery of a toolset. it's shipping a product.

## new capital calculation

c# training: 2/3 hours
pgp:           1 hour
database:     1/2 hour
winform:       1 hour

total:		   3/8 hours

next sprint:
winforms create all windows and buttons

## end sprint 3
## --------------------------------------------------------------------------
## start sprint 4

@automated
#@web
Feature: FilterProject
	I want to see list project after filter


Background: 
	Given the following project
	| PropertyName                                 | Avarta                                           | Images                                                                             | PropertyType | Content                                                                                                      | Street         | Ward        | District  | Price  | UnitPrice | Area  | BedRoom | BathRoom | PackingPlace | UserID | Create_at  | Create_post | Status | Note | Update_at  | Sale_ID |
	| PIS Top Apartment                            | 1.9SC_9220-watermark.jpg                          | a17584387317552326.jpg,AvatarNone17100766117552327.png,images1709523917552328.jpg,| 1            | The surrounding neighborhood is very much localized with a great number of local shops.						 | 748		      | 2		    | 2		    | 10000  | VND       | 120m2 | 3       | 2        | 1            | 1      | 2017-11-09 | 2017-11-09  | 3      | Done | 2017-11-23 | 2       |
	| ViLa Q7                                      | DSC_1103-watermark.jpg                             | images172300301.jpg                                                              | 2            | Brand new apartments with unbelievable river and city view, completely renovated and tastefully furnished.	 | 750            | 3			| 2		    | 70000  | VND       | 120m2 | 3       | 4        | 1            | 1      | 2017-11-09 | 2017-11-09  | 3      | Done | 2017-11-23 | 2       |
	| PIS Serviced Apartment – Style               | DSC_4173-watermark.jpg							| a - Copy17095239.jpg,images (1) - Copy17095242.jpg,images17095242.jpg,			   | 3            | The well equipped kitchen is opened on a cozy living room and a dining area with table and chairs..		     | 749			  | 4		    | 2		    | 30000  | VND       | 130m2 | 2       | 3        | 1            | 4      | 2017-11-09 | 2017-11-09  | 3      | Done | 2017-11-23 | 3       |
	| Vinhomes Central Park L2 – Duong’s Apartment | galaxy-9-3-watermark-1.jpg                          | images1702244617042862.jpg,                                                     | 2            | Vinhomes Central Park is a new development that is in the heart of everything that Ho Chi Minh has to offer. | 755			  | 33			| 3			| 110000 | VND       | 150m2 | 4       | 2        | 1            | 1      | 2017-11-09 | 2017-11-09  | 3      | Done | 2017-11-23 | 3       |
	| Saigon Pearl Ruby Block                      | DSC_7895-watermark.jpg                          | images17423697317334243.jpg,PIS_4622-Edit17463610217334244.jpg,                     | 1			  | Studio apartment at central of CBD, nearby Ben Thanh market, Bui Vien Backpacker Area, 23/9 park…		     | 758			  | 35	        | 3			| 30000  | VND       | 130m2 | 3       | 5        | 1            | 4      | 2017-11-09 | 2017-11-09  | 3      | Done | 2017-11-23 | 2       |
	

Scenario: FilterProject
	When I input Chuong My into Filter '2'
	Then I should see list projects
	| PropertyName                                 |
	| PIS Top Apartment                            |
	| ViLa Q7                                      |
	| PIS Serviced Apartment – Style			   |
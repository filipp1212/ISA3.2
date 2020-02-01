Gunnari näide
//Praegu 9 testi kukkub läbi
//
//2623 testi on OK ja 12 on tegemata
//
//Viskasin kogu Blazori ja FlexGrid asjad välja. Neid ei saa praegu veel kasutada.
//
//Ilmselt tuleb see FlexGrid ikka ise kirjutada :(
//
//Praegu vähemalt asjad toimivad.

Now that one can tell where a shipment is going to and coming from, and when it is being shipped, it is necessary to know what is being shipped and how many items are being shipped. 
The SHIPMENT ITEM entity will provide information on how many items will be shipped or are scheduled to be shipped.

Details about what was shipped may be found in either the GOOD entity if it is a standard product or in the shipment contents description , if the item is not a standard item that is kept on file. 
For example, there could be a one-time incoming shipment from a supplier that is not maintained in the GOOD entity because it is not a standard product.


How to party roles in manufacturing: https://learning.oreilly.com/library/view/the-data-model/9780471353485/09_chapter_2.html#figure_2_1

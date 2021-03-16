# The Alchemist Read Me

Link to gameplay video:https://drive.google.com/file/d/1SlP9T_AfexjQHp19FfFhW3PRJW__SCjE/view?usp=sharing

Link to code video: https://youtu.be/xZqrn8AMFKo

---

### Overview of Game:
In Alchemist the player is a magician living in a workshop set in the forests close to several towns. Each day the player gets new requests from the residents of the towns asking for help in the form of potions and magical items. These requests are generally tied to a need of the town due to ailment or distress. The player must use the limited resources within their workshop to fulfill these requests, or face the repercussions of not having them addressed.

At the end of each day, the player sees the repercussions of their decisions. They are able to order new resources. Then they start the next day. The ultimate goal being to keep all of the towns healthy and alive, and avoiding any narrative paths that might cause the player to meet an early demise.

---

### Overview of Gameplay:
The game phases are structured into days. Before the start of each day the player can order resources for their workshop. This opens up a number of choices to the player in terms of their resource management. For example they may choose to invest in seeds for a plant that will have higher return after a few days of growing, or purchase a plant outright in order to have the stock on hand immediately.

After deciding upon their order of resources the day begins for the player. They appear in their workshop that has all the resources and tools at their disposal. By the door the player finds a number of requests for the day from the neighbouring town. These provide a piece of narrative element explaining what the situation is in the town, what they are requesting to remedy it, and any potential compensation for the work. It is then up to the player to decide whether or not they will fulfill each order. The requests also may be tied to narrative trees, thus the decisions made will affect future orders.

The player can move around their workshop interacting with resources and objects in order to make items. For example with an empty hand they might click on a plant to harvest it. Then they might click on a drying rack to dry out the plant for the next day. They could then with their empty hand pick up the plant they had set out to dry the day before and add it to a pot to finish their potion. The potion then can be assigned to an order to be delivered at the end of the day.

After choosing to end the day the player is shown a map of the area, including the nearby towns. If there are any updates about the conditions of the towns based on the decisions of the player, these are shown. The day is then started anew.

---

### How to play:
Start the game and hit the play button. You can walk around the workshop using the W A S D keys and the mouse to look around. The player can interact with and pick up objects by using the F key. The player can rotate and inspect objects by using the mouse wheel and also holding down the right mouse button and moving the mouse. At anytime the player can press the P key to pause the game.

The player can view the world map at any point by opening up the world book on the counter down stairs. 

The player can interact with different crafting stations whilst holding ingredients to grind, dry, distill, heat or grow different potion ingredients. Potions can be collected by using a flask on the cauldron.

Potions / ingredients can be shipped out to cure the town folk by placing them into the different shipping out boxes. The associated town can be seen in the text display when hovering over the shipping boxes.

The day can be ended by interacting with the bed upstairs. This is where you can buy new ingredients for the next day and see how your potions have affected the local towns.

If a town reaches a certain level of unrest the game ends. Make sure you keep the towns folk happy!

---

### Code contributions:

Towns
- Town setup and creation - Lily (All), Toby (Touched), Ben (Touched)
- Disease system - Lily (Most), Ben (Some)
- Request system - Lily (All)

Gameplay loop
- Sleeping system - Toby (All)
- End of day loop - Ben (Some), Sam (Some), Toby (Some), Lily (Some)
- Shipping out - Sam (Half), Lily (Half), Ben (Touched), Toby (Touched)
- Shop - Toby (Most), Lily (Some)
- Game over - Toby (All)

Menus
- Main menu - Toby (All)
- Pause menu - Toby (All)
- Shop menu - Toby (All)
- Ingredients book - Toby (All)
- Town menu - Toby (All)

Player character
- Movement - Sam (Most), Ben (Some)

Interaction
- Picking up objects - Sam (All)
- Inspecting objects - Sam (All)
- Crafting system - Ben (Half), Sam (Half)
- Potion system - Ben (Most), Sam (Some), Lily (Some)
- Interaction architecture - Ben (Some), Sam (Some), Toby (Some)

Growing System
- Planting and growing ingredients - Ben (Half), Sam (Half)

Sounds
- Music - Ben (All)
- Gameplay sounds - Ben (All)

Miscellaneous
- Object outlines - Sam (All)
- Object spawner - Sam (All)

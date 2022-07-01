# Unity-echo3D-Demo-TarotCardGame
Create a random tarot card game in Unity. Note: the tarot is sacred for many so please handle with care.

## Version
[Unity 2020.3.25f1](https://unity3d.com/get-unity/download/archive)

## Register
Don't have an echo3D API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

## Setup
* Clone this [repo](https://github.com/echo3Dco/Unity-echo3D-Demo-TarotCardGame/).
* [Install the echo3D Unity SDK](https://docs.echo3D.co/unity/installation).
* [Add the assets](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D console from the Unity 'Models' folder.
* Uncheck the [Security](https://docs.echo3d.co/web-console/deliver-pages/security-page) box in your console.
* Open the _SampleScene_ scene.
* Drag the echo3D script to all objects under "Card" (0TheFool - 4Emperor).
* [Add the API key](https://docs.echo3D.co/unity/using-the-sdk) and entry ID for each object in the Inspector.
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/175661063-031a0d62-af0f-4335-be12-b73317527e54.png)
![Hierarchy](https://user-images.githubusercontent.com/99516371/176974975-45d6f83b-80dc-4977-8dcc-2b77efed1490.png)

* In the Hierarchy, make sure to the box is unchecked for the Sprite Renderer for Background
* Press Play in Unity to see where the Background asset shows up in the scene so you can modify the [metadata](https://docs.echo3d.co/unity/transforming-content) in the console.
* Adjust the [metadata](https://docs.echo3d.co/unity/transforming-content) in the echo3D console so it matches the spawn points in the Hierarchy.

## Run
Press Play in Unity. Click "Draw" 3 times to distribute the cards. Click on each card to move it to the Discard pile. Cards will automatically disappear. Do that until there are 0 cards left in the Deck.

## Learn More
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Sources
* Deck assets: [Bennion Kenny](https://www.bennionkearny.com/wp-content/uploads/2019/11/Tarot-Card-Deck.pdf)

## Screenshots
![GameplayGIF](https://user-images.githubusercontent.com/99516371/176974859-e6855810-19ca-4fd4-be57-d1fa1ec00ff0.gif)

![Screenshot](https://user-images.githubusercontent.com/99516371/176974856-caf86dbb-72d4-49bd-af87-f4d54b604969.png)


"""
This script was used to generate the dialogue used in Level 1 of our game.

References: http://ww2010.atmos.uiuc.edu/(Gh)/guides/mtr/hyd/smry.rxml
			https://water.usgs.gov/edu/graphics/watercycle-usgs-screen.jpg
			http://www.lvcsd.k12.ny.us/minisites/caballero/Atmosphere/Defined%20Water%20Cycle%20Vocabulary.htm
			http://slideplayer.com/slide/7578024/
"""

import asyncio
from gtts import gTTS # These voices aren't very good

async def generateDialogue(dialogue : str, name : str):
	tts = gTTS(text=dialogue, lang='en')
	tts.save("{}.mp3".format(name))
	print("Generated dialogue for {}".format(name))
	
async def main():
	first_window = "Hello and Welcome!"
	#event_loop.create_task(generateDialogue(first_window, 'first_window'))
	
	second_window = """
	Today, you will learn about two things; the Water Cycle and the characteristics
	of different bodies of water. Pay attention because you will need to know this
	information to be successful in the game!
	"""
	#event_loop.create_task(generateDialogue(second_window, 'second_window'))
	
	third_window = """
	The Water cycle, scientifically known as the Hydrologic Cycle, involves the process by which water travels throughout its environment throughout the following key procedures: Evaporation, Condensation, Precipitation, Infiltration, Transpiration, and Surface Runoff.
	"""
	#event_loop.create_task(generateDialogue(third_window, 'third_window'))
	
	fourth_window = """
	First, let's start with a simple example. How does it rain? Well, it all begins with Evaportation. The central body of water in the area contributes to the process. This means if there is a leak in our ecosystem, the sun will evaporate the water in the lake. Put simply, the liquid water in the lake will turn into a gas.
	"""
	#event_loop.create_task(generateDialogue(fourth_window, 'fourth_window'))

		
	fifth_window = """
	Once the water has evaporated, Condensation will occur and the evaporated water will turn into, for example, a cloud. This cloud will be where our rain water falls to the earth from!
	"""
	#event_loop.create_task(generateDialogue(fifth_window, 'fifth_window'))


if __name__ == '__main__':
	try:
		event_loop = asyncio.get_event_loop()
		# Asynchronously generate all of the MP3s as tasks within main()
		event_loop.run_until_complete(main())
	except Exception as e:
		print(e)
	finally:
		event_loop.close()
"""
Hey there! Welcome to HydroCycle! My name is Carolyn and I'll be your teacher today!

I'm here to guide you through water cycle!

Today, you will learn about two things...

...the Water Cycle and the characteristics of different bodies of water.

Pay attention because you will need to know this information to be successful in Level 2 of the game!

The Water cycle, scientifically known as the Hydrologic Cycle...

...involves the process by which water travels throughout its environment.

The process involves the following key procedures: 

Evaporation, Condensation, Precipitation, Infiltration, Transpiration, and Surface Runoff.

First, let's start with a simple example. How does it rain? 

Well, it all begins with EVAPORATION.

The central body of water in the area contributes to the process. 

This means if there is a lake in our ecosystem, the sun will evaporate the water in the lake. 

Put simply, the liquid water in the lake will turn into a gas.

Once the water has evaporated, CONDENSATION will occur and the evaporated water will turn into a cloud!

This cloud will be where our rain water falls to the earth from!

This process of liquid water falling from clouds to the Earth is known as PRECIPITATION.

After the water has fallen to the Earth, INFILTRATION occurs.

With Infiltration, water soaks into the soil and moves into the rocks. When solid water, like snow and hail, infiltration...

...does not occur until they melt. Next, TRANSPIRATION happens when this infiltrated water is received by the roots of plants. 

These plants will then carry the water up through their leaves and add the water back into the atmosphere for another round...

...of condensation and precipitation.

You can remember this by attributing transpiration to evaporation, but with plants!

Lastly, there's SURFACE RUNOFF!

Surface runoff occurs when precipitated water flows over the land surface and back into major bodies of water.

And then the cycle starts all over again!

Now that you know everything you need about the Water Cycle...

Click the button at the classroom door to start Level 2!
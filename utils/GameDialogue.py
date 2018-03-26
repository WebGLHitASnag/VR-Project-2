"""
This script was used to generate the dialogue used in Level 1 of our game.

References: http://ww2010.atmos.uiuc.edu/(Gh)/guides/mtr/hyd/smry.rxml
			https://water.usgs.gov/edu/graphics/watercycle-usgs-screen.jpg
			http://www.lvcsd.k12.ny.us/minisites/caballero/Atmosphere/Defined%20Water%20Cycle%20Vocabulary.htm
			http://slideplayer.com/slide/7578024/
"""

import asyncio
from gtts import gTTS

async def generateDialogue(dialogue : str, name : str):
	tts = gTTS(text=dialogue, lang='en')
	tts.save("{}.mp3".format(name))
	
async def main():

	first_window = "Hello and Welcome!"

	second_window = """
	Today, you will learn about two things; the Water Cycle and the characteristics
	of different bodies of water. Pay attention because you will need to know this
	information to be successful in the game!
	"""

	third_window = """
	The Water cycle, scientifically known as the Hydrologic Cycle, involves the process by which water travels throughout its environment throughout the following key procedures: Evaporation, Condensation, Precipitation, Infiltration, Transpiration, and Surface Runoff.
	"""

	fourth_window = """
	First, let's start with a simple example. How does it rain? Well, it all begins with Evaportation. The central body of water in the area contributes to the process. This means if there is a leak in our ecosystem, the sun will evaporate the water in the lake. Put simply, the liquid water in the lake will turn into a gas.
	"""
	
	fifth_window = """
	Once the water has evaporated, Condensation will occur and the evaporated water will turn into, for example, a cloud. This cloud will be where our rain water falls to the earth from!
	"""

if __name__ == '__main__':
	try:
		event_loop = asyncio.get_event_loop()
		# Asynchronously generate all of the MP3s as tasks within main()
		event_loop.run_until_complete(main())
	except Exception as e:
		print(e)
	finally:
		event_loop.close()
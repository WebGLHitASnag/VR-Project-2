#pragma strict

var waterLevel : float;
private var isUnderWater : boolean;
private var normalColor : Color;
private var underWaterColor : Color;

function Start () {
	normalColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
	underWaterColor = new Color(0.22f, 0.65f, 0.77f, 0.5f);
}

function Update () {
	if ((transform.position.y < 188) != isUnderWater) {
		isUnderWater = transform.position.y < 188;
		if (isUnderWater) {
			setUnderWater ();
		}
		if (!isUnderWater) {
			setNormal ();
		}
	}
}

function setNormal () {
	RenderSettings.fogColor = normalColor;
	RenderSettings.fogDensity = 0.001f;
	Physics.gravity = new Vector3(0, -9.81, 0);
}

function setUnderWater () {
	RenderSettings.fogColor = underWaterColor;
	RenderSettings.fogDensity = 0.03f;
	Physics.gravity = new Vector3(0, -2.5, 0);
}
# Projection Mapping Intro

## Open Source Projection Mapper for class

1. Download projection_mapper
2. Open it in Processing
3. Sketch -> Import Library -> Add Library
4. Search "keystone"
5. Install Keystone library
6. Search "video" look for the one with "GStreamer" and Processing Logo
7. Install Video library
8. Sketch -> Add Library -> Import Library
9. Search "Syphon", select, and install
10. Run projection_mapper

Controls:
+ Pressing '1' adds an image
+ Pressing '2' adds a movie
+ Pressing '3' adds the latest Syphon source

## Syphon
[Download Syphon](http://syphon.v002.info/)
+ Caution! Mac only!

### Syphon in Unity

First get a few things ready:

1. Edit -> Project Settings -> Player
2. Enable "Run in Background"
	+ This allows your Unity project to run live in the background, so that you can have a projection mapping program open simultaneously.
3. Open "KlakSyphon.unitypackage" with your Unity project open (from [here](https://github.com/keijiro/KlakSyphon))
4. Attach "SyphonServer.cs" to your Main Camera

## Troubleshooting
+ Having multiple Syphon servers open at the same time crashes the Processing sketch. 
+ Make sure Unity is in play mode
+ Entering/Existing Playmode while the sketch is running will also crash it


## Windows Alternatives

[Spout](http://spout.zeal.co/) is like Syphon but for Windows
+ [Spout for Processing](https://github.com/leadedge/SpoutProcessing) would let you use it in Processing (you'll have to rewrite the sketch some though)
+ [KlakSpout](https://github.com/keijiro/KlakSpout) is like Funnel, it lets you use Spout in Unity
You'll need to rewrite our mapping program in Processing to use Spout instead of Syphon, or use a different mapper:
+ [VPT](https://hcgilje.wordpress.com/vpt/) is free, but a little difficult to use
+ [Facade Signage](https://www.videomappingsoftware.com/download/) is easy to use and has a 21 day free trial
+ [MadMapper](https://madmapper.com/) is the software most people use, but it isn't free

## Projection Mapping Ideas
[Inspiration](http://projection-mapping.org/inspiration/)
[How to Project on 3D Geometry](https://vvvv.org/documentation/how-to-project-on-3d-geometry)

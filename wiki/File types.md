* ipk: Bundle
* isc: Scene
* isg: Generic object. Can be anything, but it is still readable thanks to the <a href="../Serialization" title="Serialization">serialization system for generics</a>.
* act: Actor (NOTE: In Rayman Origins, act files are Actor Templates)!
* tpl: Actor_Template
* fcg: FriseConfig - the template of a Frise object
* msh: GFXMaterialShader_Template - Material Shader info
* gmt: RO2_GameMaterial_Template - Game material, contains all info about the collision (e.g. can you wall run on it, is it slippery, etc.)
* anm: AnimTrack - an animation
* skl: AnimSkeleton - the rig for an animated character
* pbk: AnimPatchBank - UVs and positions on the rig of "patches", parts of a sprite sheet.
* tga: TextureCooked - A texture with a header
* png: TextureCooked - A texture with a header

### Still unparsed files
* sgs: Scene reference file, I think. Seems to contain info on what the scene is, like its level name, etc.

### Special files
* atlascontainer: UVAtlasManager - Contains all the UV data of all non-animated objects in the bundle. The texture filename is used to access it, so creating a new texture file and using it in a scene with a TextureGraphicComponent requires modifying the atlascontainer file.
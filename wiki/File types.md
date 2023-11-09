### General
* ipk: Bundle
* ckd: Cooked - A lot of the original files used by the UbiArt editor were text-based, LUA files. When building or cooking the game into its final release format, the UbiArt tools wrote these files in a binary format which allows for better performance.
* isg: Generic object - Can be anything, but it is still readable thanks to the <a href="../Serialization" title="Serialization">serialization system for generics</a>.

### Scene
* isc: Scene
* tsc: Template Scene - Same as a Scene, but these scenes were reused often and placed as SubSceneActors (actors containing a scene) in various levels.
* sgs: SceneConfig - While a Scene can have more than one SceneConfig, only one can be set to "active" at the same time. This file contains that active SceneConfig only. Mainly used to tell the game which game mode to use for the scene (platform, challenge, invasion...). However, both this file and the SceneConfig in the Scene file seem to be unused - instead, the game uses what is in the SceneConfigManager (see Special files below)

### Pickables
* act: Actor (NOTE: In Rayman Origins, act files are Actor Templates)!
* tpl: Actor_Template
* frz: Frise
* fcg: FriseConfig - the template of a Frise object
* mrz: MetaFrise - Added for Legends but not used in the final game (converted into regular Frises), this combines different Frises into one for easier placement (e.g. a wooden castle walkway needs a floor, wooden bars in front and in the back, and a roof that are always at the same distance from each other. Using a MetaFrise it is possible to place all of those by defining one line of points.)
* mcg: MetaFriseConfig - the template of a MetaFrise object

### Animation
* anm: AnimTrack - an animation
* skl: AnimSkeleton - the rig for an animated character
* pbk: AnimPatchBank - UVs and positions on the rig of "patches", parts of a sprite sheet.
* asc: AnimMeshVertex - a different animation format for cheaper animations (vertex animations only). One file contains multiple animations.

### 3D Geometry
* m3d: Mesh3D - geometry for a 3D animated character
* a3d: Animation3D - animations for a 3D animated character
* s3d: Skeleton3D - the rig for a 3D animated character

### Textures
These files are all TextureCooked: textures with special UbiArt headers (only in Legends and above). Originally these files were different formats indicated by their extensions, but when cooked they were converted to a texture format better suited for the platform's GPU (often DDS).
* tga: TextureCooked
* png: TextureCooked

### Other
* msh: GFXMaterialShader_Template - Material Shader info
* gmt: RO2_GameMaterial_Template - Game material, contains all info about the collision (e.g. can you wall run on it, is it slippery, etc.)
* tfn: Font file - Maps characters onto regions of a raster/image font
* wav: Sound file - originally just a RIFF WAV file, but when cooked, it was converted to a format exclusive to the game's audio engine, RAKI (Legends and above only)
* tbl: Table file - Editor format that seems to hold any type of array. Uncompiled examples were found in Gravity Falls for 3DS.
* tia: TagIconAssociation - Editor format that links the Tag icons to different tags. So far not found in any released UbiArt game.
* ilu: Unknown editor format. Seems to contain any generic LUA code.
* tbll: Unknown editor format

### Special files
* secure_fat.gf: GlobalFat - This file contains a list of every file used by the game. If a file is added to a bundle but not specified in GlobalFat, then the game will not recognize it (unless it is in a patch bundle). This means that when adding files to the game, the GlobalFat needs to be rebuilt.
* atlascontainer: UVAtlasManager - Contains all the UV data of all non-animated objects in the bundle. The texture filename is used to access it, so creating a new texture file and using it in a scene with a TextureGraphicComponent requires modifying the atlascontainer file.
* sgscontainer: SceneConfigManager - Contains a list of active scene configs for all scenes that have them.
* localisation.loc8: Localisation_Template - Contains the localized versions of all text in the game and references to localized audio, for every language supported by the game.
* common.alias8: AliasManager - Provides the possibility of using simple string aliases for certain important paths. Mostly used for the editor. For example, because this contains the mapping "gameconfig" -> "enginedata/gameconfig/gameconfig.isg", the game and editor can refer to this file using just "gameconfig".
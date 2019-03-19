using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Scene : CSerializable {
		[Serialize("ENGINE_VERSION"                    )] public uint ENGINE_VERSION;
		[Serialize("DEPENDENCIES"                      )] public CArray<Path> DEPENDENCIES;
		[Serialize("FRISE"                             )] public CList<Frise> FRISE;
		[Serialize("METAFRIEZE"                        )] public CList<MetaFrieze> METAFRIEZE;
		[Serialize("ACTORS"                            )] public CArray<Actor> ACTORS;
		[Serialize("friezeConnections"                 )] public CList<FriezeConnectionResult> friezeConnections;
		[Serialize("sceneConfigs"                      )] public SceneConfigs sceneConfigs;
		[Serialize("TABS"                              )] public Placeholder TABS;
		[Serialize("GRIDUNIT"                          )] public float GRIDUNIT;
		[Serialize("PLATFORM_FILTER"                   )] public Placeholder PLATFORM_FILTER;
		[Serialize("MUSIC_THEME_PATH"                  )] public Path MUSIC_THEME_PATH;
		[Serialize("MUSIC_THEME"                       )] public StringID MUSIC_THEME;
		[Serialize("DEPTH_SEPARATOR"                   )] public int DEPTH_SEPARATOR;
		[Serialize("NEAR_SEPARATOR"                    )] public Matrix44 NEAR_SEPARATOR;
		[Serialize("FAR_SEPARATOR"                     )] public Matrix44 FAR_SEPARATOR;
		[Serialize("uint__0"                           )] public uint uint__0;
		[Serialize("uint__1"                           )] public uint uint__1;
		[Serialize("CList<Path>__2"                    )] public CList<Path> CList_Path__2;
		[Serialize("Path__3"                           )] public Path Path__3;
		[Serialize("CArray<Generic<Pickable>>__4"      )] public CArray<Generic<Pickable>> CArray_Generic_Pickable__4;
		[Serialize("CArray<Generic<Pickable>>__5"      )] public CArray<Generic<Pickable>> CArray_Generic_Pickable__5;
		[Serialize("CList<FriezeConnectionResult>__6"  )] public CList<FriezeConnectionResult> CList_FriezeConnectionResult__6;
		[Serialize("StringID__7"                       )] public StringID StringID__7;
		[Serialize("uint__8"                           )] public uint uint__8;
		[Serialize("uint__9"                           )] public uint uint__9;
		[Serialize("CArray<Path>__10"                  )] public CArray<Path> CArray_Path__10;
		[Serialize("CArray<Frise>__11"                 )] public CArray<Frise> CArray_Frise__11;
		[Serialize("CArray<MetaFrieze>__12"            )] public CArray<MetaFrieze> CArray_MetaFrieze__12;
		[Serialize("CArray<Generic<Actor>>__13"        )] public CArray<Generic<Actor>> CArray_Generic_Actor__13;
		[Serialize("CArray<FriezeConnectionResult>__14")] public CArray<FriezeConnectionResult> CArray_FriezeConnectionResult__14;
		[Serialize("SceneConfigs__15"                  )] public SceneConfigs SceneConfigs__15;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					SerializeField(s, nameof(uint__0));
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					SerializeField(s, nameof(uint__1));
				}
				if (s.HasFlags(SerializeFlags.Flags0)) {
					SerializeField(s, nameof(CList_Path__2));
					SerializeField(s, nameof(Path__3));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(CArray_Generic_Pickable__4));
					SerializeField(s, nameof(CArray_Generic_Pickable__5));
					SerializeField(s, nameof(CList_FriezeConnectionResult__6));
					SerializeField(s, nameof(StringID__7));
				}
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ENGINE_VERSION));
				if (s.HasFlags(SerializeFlags.Flags6)) {
					SerializeField(s, nameof(ENGINE_VERSION));
					if (s.HasFlags(SerializeFlags.Flags7)) {
						SerializeField(s, nameof(TABS));
						SerializeField(s, nameof(GRIDUNIT));
						SerializeField(s, nameof(PLATFORM_FILTER));
						if (s.HasFlags(SerializeFlags.Flags0)) {
							SerializeField(s, nameof(DEPENDENCIES));
							SerializeField(s, nameof(MUSIC_THEME_PATH));
						}
						SerializeField(s, nameof(FRISE));
						SerializeField(s, nameof(ACTORS));
						SerializeField(s, nameof(friezeConnections));
						SerializeField(s, nameof(MUSIC_THEME));
					}
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					SerializeField(s, nameof(ENGINE_VERSION));
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					SerializeField(s, nameof(ENGINE_VERSION));
				}
				if (s.HasFlags(SerializeFlags.Flags9)) {
					SerializeField(s, nameof(TABS));
					SerializeField(s, nameof(GRIDUNIT));
					SerializeField(s, nameof(DEPTH_SEPARATOR));
					SerializeField(s, nameof(NEAR_SEPARATOR));
					SerializeField(s, nameof(FAR_SEPARATOR));
					SerializeField(s, nameof(PLATFORM_FILTER));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(DEPENDENCIES));
				}
				SerializeField(s, nameof(FRISE));
				SerializeField(s, nameof(METAFRIEZE));
				SerializeField(s, nameof(ACTORS));
				SerializeField(s, nameof(friezeConnections));
				SerializeField(s, nameof(sceneConfigs));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(ENGINE_VERSION));
				if (s.HasFlags(SerializeFlags.Flags6)) {
					SerializeField(s, nameof(ENGINE_VERSION));
				}
				if (s.HasFlags(SerializeFlags.Flags9)) {
					SerializeField(s, nameof(TABS));
					SerializeField(s, nameof(GRIDUNIT));
					SerializeField(s, nameof(DEPTH_SEPARATOR));
					SerializeField(s, nameof(NEAR_SEPARATOR));
					SerializeField(s, nameof(FAR_SEPARATOR));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(DEPENDENCIES));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					SerializeField(s, nameof(uint__8));
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					SerializeField(s, nameof(uint__9));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(CArray_Path__10));
				}
				SerializeField(s, nameof(CArray_Frise__11));
				SerializeField(s, nameof(CArray_MetaFrieze__12));
				SerializeField(s, nameof(CArray_Generic_Actor__13));
				SerializeField(s, nameof(CArray_FriezeConnectionResult__14));
				SerializeField(s, nameof(SceneConfigs__15));
			} else {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					SerializeField(s, nameof(ENGINE_VERSION));
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					SerializeField(s, nameof(ENGINE_VERSION));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(DEPENDENCIES));
					SerializeField(s, nameof(DEPENDENCIES));
				}
				SerializeField(s, nameof(FRISE));
				SerializeField(s, nameof(METAFRIEZE));
				SerializeField(s, nameof(ACTORS));
				SerializeField(s, nameof(friezeConnections));
				SerializeField(s, nameof(sceneConfigs));
			}
		}
		public override uint? ClassCRC => 0x0C75B172;
	}
}


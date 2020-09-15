using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Scene : BaseObject {
		public uint ENGINE_VERSION;
		public CArray<Path> DEPENDENCIES;
		public CList<Frise> FRISE;
		public CList<MetaFrieze> METAFRIEZE;
		public CArray<Generic<Actor>> ACTORS;
		public CList<FriezeConnectionResult> friezeConnections;
		public SceneConfigs sceneConfigs;
		public CList<Path> TABS;
		public float GRIDUNIT;
		public TargetFilterList PLATFORM_FILTER;
		public Path MUSIC_THEME_PATH;
		public StringID MUSIC_THEME;
		public int DEPTH_SEPARATOR;
		public Matrix44 NEAR_SEPARATOR;
		public Matrix44 FAR_SEPARATOR;
		public CArray<Generic<Pickable>> FRISE_ORIGINS;
		public CArray<Generic<Pickable>> ACTORS_ORIGINS;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					ENGINE_VERSION = s.Serialize<uint>(ENGINE_VERSION, name: "ENGINE_VERSION");
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					ENGINE_VERSION = s.Serialize<uint>(ENGINE_VERSION, name: "ENGINE_VERSION");
				}
				if (s.HasSerializerFlags(CSerializerObject.Flags.Flags0)) {
					DEPENDENCIES = s.SerializeObject<CArray<Path>>(DEPENDENCIES, name: "DEPENDENCIES");
					MUSIC_THEME_PATH = s.SerializeObject<Path>(MUSIC_THEME_PATH, name: "MUSIC_THEME_PATH");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					FRISE_ORIGINS = s.SerializeObject<CArray<Generic<Pickable>>>(FRISE_ORIGINS, name: "FRISE_ORIGINS");
					ACTORS_ORIGINS = s.SerializeObject<CArray<Generic<Pickable>>>(ACTORS_ORIGINS, name: "ACTORS_ORIGINS");
					friezeConnections = s.SerializeObject<CList<FriezeConnectionResult>>(friezeConnections, name: "friezeConnections");
					MUSIC_THEME = s.SerializeObject<StringID>(MUSIC_THEME, name: "MUSIC_THEME");
				}
			} else if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					ENGINE_VERSION = s.Serialize<uint>(ENGINE_VERSION, name: "ENGINE_VERSION");
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					ENGINE_VERSION = s.Serialize<uint>(ENGINE_VERSION, name: "ENGINE_VERSION");
				}
				if (s.HasSerializerFlags(CSerializerObject.Flags.Flags0)) {
					DEPENDENCIES = s.SerializeObject<CArray<Path>>(DEPENDENCIES, name: "DEPENDENCIES");
					MUSIC_THEME_PATH = s.SerializeObject<Path>(MUSIC_THEME_PATH, name: "MUSIC_THEME_PATH");
				} else if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					TABS = s.SerializeObject<CList<Path>>(TABS, name: "TABS");
					GRIDUNIT = s.Serialize<float>(GRIDUNIT, name: "GRIDUNIT");
					PLATFORM_FILTER = s.SerializeObject<TargetFilterList>(PLATFORM_FILTER, name: "PLATFORM_FILTER");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					FRISE_ORIGINS = s.SerializeObject<CArray<Generic<Pickable>>>(FRISE_ORIGINS, name: "FRISE_ORIGINS");
					ACTORS_ORIGINS = s.SerializeObject<CArray<Generic<Pickable>>>(ACTORS_ORIGINS, name: "ACTORS_ORIGINS");
					friezeConnections = s.SerializeObject<CList<FriezeConnectionResult>>(friezeConnections, name: "friezeConnections");
					MUSIC_THEME = s.SerializeObject<StringID>(MUSIC_THEME, name: "MUSIC_THEME");
				}
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					ENGINE_VERSION = s.Serialize<uint>(ENGINE_VERSION, name: "ENGINE_VERSION");
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					ENGINE_VERSION = s.Serialize<uint>(ENGINE_VERSION, name: "ENGINE_VERSION");
				}
				if (s.HasFlags(SerializeFlags.Flags9)) {
					TABS = s.SerializeObject<CList<Path>>(TABS, name: "TABS");
					GRIDUNIT = s.Serialize<float>(GRIDUNIT, name: "GRIDUNIT");
					DEPTH_SEPARATOR = s.Serialize<int>(DEPTH_SEPARATOR, name: "DEPTH_SEPARATOR");
					NEAR_SEPARATOR = s.SerializeObject<Matrix44>(NEAR_SEPARATOR, name: "NEAR_SEPARATOR");
					FAR_SEPARATOR = s.SerializeObject<Matrix44>(FAR_SEPARATOR, name: "FAR_SEPARATOR");
					PLATFORM_FILTER = s.SerializeObject<TargetFilterList>(PLATFORM_FILTER, name: "PLATFORM_FILTER");
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					DEPENDENCIES = s.SerializeObject<CArray<Path>>(DEPENDENCIES, name: "DEPENDENCIES");
				}
				FRISE = s.SerializeObject<CList<Frise>>(FRISE, name: "FRISE");
				METAFRIEZE = s.SerializeObject<CList<MetaFrieze>>(METAFRIEZE, name: "METAFRIEZE");
				ACTORS = s.SerializeObject<CArray<Generic<Actor>>>(ACTORS, name: "ACTORS");
				friezeConnections = s.SerializeObject<CList<FriezeConnectionResult>>(friezeConnections, name: "friezeConnections");
				sceneConfigs = s.SerializeObject<SceneConfigs>(sceneConfigs, name: "sceneConfigs");
			} else {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					ENGINE_VERSION = s.Serialize<uint>(ENGINE_VERSION, name: "ENGINE_VERSION");
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					ENGINE_VERSION = s.Serialize<uint>(ENGINE_VERSION, name: "ENGINE_VERSION");
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					DEPENDENCIES = s.SerializeObject<CArray<Path>>(DEPENDENCIES, name: "DEPENDENCIES");
				}
				FRISE = s.SerializeObject<CList<Frise>>(FRISE, name: "FRISE");
				METAFRIEZE = s.SerializeObject<CList<MetaFrieze>>(METAFRIEZE, name: "METAFRIEZE");
				ACTORS = s.SerializeObject<CArray<Generic<Actor>>>(ACTORS, name: "ACTORS");
				friezeConnections = s.SerializeObject<CList<FriezeConnectionResult>>(friezeConnections, name: "friezeConnections");
				sceneConfigs = s.SerializeObject<SceneConfigs>(sceneConfigs, name: "sceneConfigs");
			}
		}
		public override uint? ClassCRC => 0x0C75B172;
	}
}


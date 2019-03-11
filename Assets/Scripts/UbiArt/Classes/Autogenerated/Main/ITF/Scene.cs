using UnityEngine;

namespace UbiArt.ITF {
	public partial class Scene : CSerializable {
		[Serialize("ENGINE_VERSION"   )] public uint ENGINE_VERSION;
		[Serialize("DEPENDENCIES"     )] public CArray<Path> DEPENDENCIES;
		[Serialize("FRISE"            )] public CList<Frise> FRISE;
		[Serialize("METAFRIEZE"       )] public CList<MetaFrieze> METAFRIEZE;
		[Serialize("ACTORS"           )] public CArray<Actor> ACTORS;
		[Serialize("friezeConnections")] public CList<FriezeConnectionResult> friezeConnections;
		[Serialize("sceneConfigs"     )] public SceneConfigs sceneConfigs;
		[Serialize("TABS"             )] public Placeholder TABS;
		[Serialize("GRIDUNIT"         )] public float GRIDUNIT;
		[Serialize("PLATFORM_FILTER"  )] public Placeholder PLATFORM_FILTER;
		[Serialize("MUSIC_THEME_PATH" )] public Path MUSIC_THEME_PATH;
		[Serialize("MUSIC_THEME"      )] public StringID MUSIC_THEME;
		[Serialize("DEPTH_SEPARATOR"  )] public bool DEPTH_SEPARATOR;
		[Serialize("NEAR_SEPARATOR"   )] public Matrix44 NEAR_SEPARATOR;
		[Serialize("FAR_SEPARATOR"    )] public Matrix44 FAR_SEPARATOR;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ENGINE_VERSION));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
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
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags7)) {
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
			} else {
				if (s.HasFlags(SerializeFlags.Flags7)) {
					SerializeField(s, nameof(ENGINE_VERSION));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
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


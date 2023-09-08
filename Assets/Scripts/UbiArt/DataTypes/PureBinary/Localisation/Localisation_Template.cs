namespace UbiArt.Localisation {
	// See: ITF::Localisation_Template::serialize
	// loc8 file
	public class Localisation_Template : CSerializable {
		public CMap<int, CMap<LocalisationId, LocText>> strings;
		public CMap<LocalisationId, LocAudio> audio;
		public CListO<Path> paths;
		public uint maxLanguagesCount;
		public uint[] languagesFlags;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			strings = s.SerializeObject<CMap<int, CMap<LocalisationId, LocText>>>(strings, name: "strings");
			audio = s.SerializeObject<CMap<LocalisationId, LocAudio>>(audio, name: "audio");
			paths = s.SerializeObject<CListO<Path>>(paths, name: "paths");
			// Special array with sometimes predefined size
			if (s.Settings.Game == Game.RA || s.Settings.Game == Game.RM) {
				// Adventures: length specified in file, but when writing, the script always writes 25.
				maxLanguagesCount = s.Serialize<uint>(maxLanguagesCount, name: "maxLanguagesCount");
			} else {
				// Legends: length not specified in file. When writing, the script always writes 19.
				maxLanguagesCount = 19;
			}
			if (languagesFlags == null) {
				languagesFlags = new uint[maxLanguagesCount];
			}
			for (int i = 0; i < maxLanguagesCount; i++) {
				if (s.ArrayEntryStart(name: nameof(languagesFlags), index: i)) {
					languagesFlags[i] = s.Serialize<uint>(languagesFlags[i], name: nameof(languagesFlags), index: i);
					s.ArrayEntryStop();
				}
			}
		}

		public string[] Locales => new string[] {
			"en-US",
			"fr-FR",
			"ja-JP",
			"de-DE",
			"es-ES",
			"it-IT",
			"ko-KR",
			"zh-TW",
			"pt-PT",
			"zh-CN",
			"pl-PL",
			"ru-RU",
			"nl-NL",
			"da-DK",
			"nb-NO",
			"sv-SE",
			"fi-FI",
			"pt-BR",
			"ms-MY",
			"id-ID",
			"tr-TR",
			"ar-SA",
			"ta-IN",
			"th-TH",
		};
	}
}

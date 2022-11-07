namespace UbiArt.online {
	public partial class Items : CSerializable {
		public enum ItemType {
			[Serialize("Gems"                       )] Gems                        = 1860,
			[Serialize("Elixir_common_to_uncommon"  )] Elixir_common_to_uncommon   = 2100,
			[Serialize("Elixir_anything_to_rare"    )] Elixir_anything_to_rare     = 2102,
			[Serialize("Elixir_skip_time_50_percent")] Elixir_skip_time_50_percent = 2104,
			[Serialize("Elixir_force_new_creature"  )] Elixir_force_new_creature   = 2016,
			[Serialize("Lucky_ticket"               )] Lucky_ticket                = 2108,
			[Serialize("Golden_lucky_ticket"        )] Golden_lucky_ticket         = 2110,
			[Serialize("Food"                       )] Food                        = 2236,
			[Serialize("Unknown"                    )] Unknown                     = 0,
		}
	}
}


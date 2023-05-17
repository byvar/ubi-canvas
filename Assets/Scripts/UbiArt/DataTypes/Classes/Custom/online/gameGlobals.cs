namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class gameGlobals : ICSerializable {
		public gameGlobalsContainer _params;

		public void Serialize(CSerializerObject s, string name) {
			_params = s.SerializeObject<gameGlobalsContainer>(_params, name: "params");
		}
	}
}


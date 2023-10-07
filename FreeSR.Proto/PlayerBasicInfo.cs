namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerBasicInfo
	{
		[ProtoMember(1)] public string Nickname;
		[ProtoMember(2)] public int Level;
		[ProtoMember(3)] public int Exp;
		[ProtoMember(4)] public int Stamina;
		[ProtoMember(5)] public int MCoin;
		[ProtoMember(6)] public int HCoin;
		[ProtoMember(7)] public int SCoin;
		[ProtoMember(8)] public int WorldLevel;
	}

}

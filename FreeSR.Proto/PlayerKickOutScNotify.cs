namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerKickOutScNotify
	{
		[ProtoMember(1)] public KickType KickType;
		[ProtoMember(9)] public BlackInfo BlackInfo;
	}
	
}

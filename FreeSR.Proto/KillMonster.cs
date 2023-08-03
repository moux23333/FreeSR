namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class KillMonster
	{
		[ProtoMember(12)] public int MonsterId;
		[ProtoMember(11)] public int KillNum;
	}
	
}

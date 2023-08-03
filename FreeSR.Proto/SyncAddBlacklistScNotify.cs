namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncAddBlacklistScNotify
	{
		[ProtoMember(2)] public int Uid;
	}
	
}

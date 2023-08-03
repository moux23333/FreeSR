namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncClientResVersionScRsp
	{
		[ProtoMember(6)] public int ResVersion;
		[ProtoMember(8)] public int Retcode;
	}
	
}

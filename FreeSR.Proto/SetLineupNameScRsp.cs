namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetLineupNameScRsp
	{
		[ProtoMember(3)] public int Index;
		[ProtoMember(12)] public string Name;
		[ProtoMember(14)] public int Retcode;
	}
	
}

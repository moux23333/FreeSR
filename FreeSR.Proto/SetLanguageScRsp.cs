namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetLanguageScRsp
	{
		[ProtoMember(10)] public Language Language;
		[ProtoMember(14)] public int Retcode;
	}
	
}

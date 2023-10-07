namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BuffInfo
	{
		[ProtoMember(6)] public float LifeTime;
		[ProtoMember(2)] public int Level;
		[ProtoMember(3)] public Dictionary<string,float> DynamicValues;
		[ProtoMember(1)] public long AddTimeMs;
		[ProtoMember(14)] public int BaseAvatarId;
		[ProtoMember(12)] public int Count;
		[ProtoMember(4)] public int BuffId;
	}
	
}

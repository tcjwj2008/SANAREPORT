package com.smes.mw.protocol;

import net.sf.ehcache.Element;

import com.smes.mw.protocol.configuration.ConfigureService;
import com.smes.mw.protocol.configuration.ProtocolConfig;
import com.smes.mw.protocol.cache.CacheHelper;
import com.smes.mw.protocol.processors.Processor;
import com.smes.mw.protocol.session.Session;

public class ProtocolAcceptor {
	/**
	 * validate identify, session
	 * 
	 */
	// private static Hashtable processors = new Hashtable();
	public static ResultSet accept(Message message) throws SystemException,
			ApplicationException {

		// check security
		// 1 check identity
		
		Object identity = message.get("identity");
		if (identity == null
				|| !ProtocolConfig.isValidIdentity((String) identity)) {
			throw new SystemException("invalid identity: " + identity);
		}

		// 2. check call type
		Object callType = message.get("call_type");
		if (callType == null) {
			throw new SystemException("missing call_type");
		}


		return runProcessor(message);
	}

	private static ResultSet runProcessor(Message message)
			throws SystemException, ApplicationException {
		Object callType = message.get("call_type");
		Object obj = ConfigureService.getProtocolConfig().getProcessors().get(
				callType);
		if (obj == null || !(obj instanceof ProcessorInfo)) {
			throw new SystemException("no processor was found for call type: "
					+ callType);
		}
		ProcessorInfo pi = (ProcessorInfo) obj;
		try {
			// init processor
			Class processorClass = Class.forName(pi.getProcessorClassName());
			Object instance = processorClass.newInstance();
			if (!(instance instanceof Processor)) {
				throw new SystemException(pi.getProcessorClassName()
						+ " is not subclass of Processor");
			}
			Processor processor = (Processor) instance;
			// ProtocolHandler handler = new ProtocolHandler(processor,
			// message);
			return ProtocolHandler.process(processor, pi
					.getTransactionClassName(), message);

		} catch (ClassNotFoundException e) {
			throw new SystemException(e);
		} catch (InstantiationException e) {
			throw new SystemException(e.getCause());
		} catch (IllegalAccessException e) {
			throw new SystemException(e.getCause());
		}
	}
}

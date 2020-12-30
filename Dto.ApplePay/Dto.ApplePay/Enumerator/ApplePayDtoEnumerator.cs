using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay.Enumerator {

    public enum PaymentMethodType {
        debit,
        credit,
        prepaid,
        store
    }

    public enum PaymentPassActivationState {
        activated,
        requiresActivation,
        activating,
        suspended,
        deactivated
    }

    public enum LineItemType {
        final,
        pending
    }

    public enum Status {
        STATUS_SUCCESS,
        STATUS_FAILURE
    }

}

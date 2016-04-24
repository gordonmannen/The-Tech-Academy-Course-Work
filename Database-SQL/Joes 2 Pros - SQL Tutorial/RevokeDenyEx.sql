DENY ALTER ANY DATABASE TO Sara
--DENY puts a check in the Deny checkbox for that permission.

REVOKE ALTER ANY DATABASE TO Murray
--REVOKE is like UNDO that previous Grant and so it unchecks the Grant checkbox.
--REVOKE could also be used to UNDO a Deny, etc.
describe('Appointments', () => {
    it('creates an appointment and shows a confirmation message', () => {
        // TODO: set base URL in cypress.json
        cy.visit('http://localhost:4200/');
        cy.get('[data-cy-input-title]').type('Groceries');
        cy.get('[data-cy-input-date]').type('01-02-2021');
        cy.get('[data-cy-confirmation-msg]').should('eq', '01-02-2021: Groceries');
    });
});

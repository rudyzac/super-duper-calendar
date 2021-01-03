describe('Homepage', () => {
    it('shows a calendar', () => {
        cy.visit('http://localhost:4200/');
        cy.get('[data-cy=calendar]');
    })
})